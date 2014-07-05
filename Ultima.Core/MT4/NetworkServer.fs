﻿namespace Ultima.MT4


open System
open System.Net
open System.Collections.Generic
open System.Reactive.Linq
open System.Reactive.Subjects
open Ultima.MT4.Packets
open Stacks
open Stacks.Tcp
open NLog.FSharp

type NetworkServerOpts = {
    Port: int
}

type MT4Socket = ReactiveMessageClient<IMT4PacketHandler>

type MT4Client(socket: MT4Socket, company: string) = 
    let mutable cmdId = 0
    let socket = socket
    let company = company

    let GetId() = System.Threading.Interlocked.Increment(&cmdId)

    member this.OnPrice = socket.Packets.Price
    member this.OnCommandResult = socket.Packets.CommandResult
    member this.OnOrders = socket.Packets.UpdateOrders
    member this.OnHistory = socket.Packets.HistoryOrderInfo
    member this.Disconnected = socket.Disconnected

    member this.Company = company




type NetworkServer(opts: NetworkServerOpts) = 
    let log = Logger()

    let exec = ActionBlockExecutor("MT4 network server")
    let server = SocketServer(exec, IPEndPoint(IPAddress.Any, opts.Port))

    let connectedSub = ref null

    let temporarySockets = List<MT4Socket>()
    let clients = Dictionary<string, MT4Client>()

    let clientConnected = new Subject<MT4Client>()

    member this.ClientConnected with get() = clientConnected.AsObservable()
    member this.Started with get() = server.Started
    member this.Stopped with get() = server.Stopped

    member this.Start() = 
        connectedSub := server.Connected.Subscribe(this.OnConnected)
        server.Start()


    member this.Stop() = 
        clientConnected.Dispose()
        (!connectedSub).Dispose()
        server.Stop()

    member this.GetConnectedClients() =
        exec.PostTask(fun () -> clients
                                |> Seq.map (fun kv -> kv.Value)
                                |> Array.ofSeq)
        |> Async.AwaitTask


    member private this.OnConnected(c) = 
        let c = MT4Socket(FramedClient(c), ProtoBufStacksSerializer())

        c.Packets.Login.Subscribe(fun l ->
            this.RegisterClient(l.company, c)
        ) |> ignore
        c.Disconnected.Subscribe(fun (e: exn) ->
            temporarySockets.Remove(c) |> ignore
        ) |> ignore

        temporarySockets.Add(c)
        ()

    member private this.RegisterClient(company: string, c) = 
        match clients.ContainsKey(company) with
        | true ->   
            log.Warn "Already has connection with company %s registered. Dropping client %s"
                company (c.RemoteEndPoint.ToString())
            c.Close()
        | false -> 
            if not(temporarySockets.Remove(c)) then
                log.Warn "Connection %s was not in temporary socket list" (c.RemoteEndPoint.ToString())
            
            let mt4Client = MT4Client(c, company)
            clients.Add(company, mt4Client)
            c.Disconnected.Subscribe(fun e -> clients.Remove(company) |> ignore) |> ignore

            clientConnected.OnNext(mt4Client)
        ()