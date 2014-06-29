//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protocol.proto
namespace Ultima.MT4.Packets
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginDTO")]
  public partial class LoginDTO : global::ProtoBuf.IExtensible
  {
    public LoginDTO() {}
    
    private string _company;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"company", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string company
    {
      get { return _company; }
      set { _company = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SymbolRegistrationDTO")]
  public partial class SymbolRegistrationDTO : global::ProtoBuf.IExtensible
  {
    public SymbolRegistrationDTO() {}
    
    private string _symbol;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"symbol", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string symbol
    {
      get { return _symbol; }
      set { _symbol = value; }
    }
    private bool _register;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"register", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool register
    {
      get { return _register; }
      set { _register = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PriceDTO")]
  public partial class PriceDTO : global::ProtoBuf.IExtensible
  {
    public PriceDTO() {}
    
    private string _symbol;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"symbol", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string symbol
    {
      get { return _symbol; }
      set { _symbol = value; }
    }
    private double _bid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"bid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double bid
    {
      get { return _bid; }
      set { _bid = value; }
    }
    private double _ask;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double ask
    {
      get { return _ask; }
      set { _ask = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OpenOrderCommandDTO")]
  public partial class OpenOrderCommandDTO : global::ProtoBuf.IExtensible
  {
    public OpenOrderCommandDTO() {}
    
    private int _command;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int command
    {
      get { return _command; }
      set { _command = value; }
    }
    private string _symbol;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"symbol", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string symbol
    {
      get { return _symbol; }
      set { _symbol = value; }
    }
    private int _tradeCommand;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"tradeCommand", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tradeCommand
    {
      get { return _tradeCommand; }
      set { _tradeCommand = value; }
    }
    private double _volume;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"volume", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double volume
    {
      get { return _volume; }
      set { _volume = value; }
    }
    private double _openPrice;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"openPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double openPrice
    {
      get { return _openPrice; }
      set { _openPrice = value; }
    }
    private double _stopLoss;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"stopLoss", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double stopLoss
    {
      get { return _stopLoss; }
      set { _stopLoss = value; }
    }
    private double _takeProfit;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"takeProfit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double takeProfit
    {
      get { return _takeProfit; }
      set { _takeProfit = value; }
    }
    private int _slippage;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"slippage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int slippage
    {
      get { return _slippage; }
      set { _slippage = value; }
    }
    private string _comment = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string comment
    {
      get { return _comment; }
      set { _comment = value; }
    }
    private int _magicNumber = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"magicNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int magicNumber
    {
      get { return _magicNumber; }
      set { _magicNumber = value; }
    }
    private int _retries;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"retries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retries
    {
      get { return _retries; }
      set { _retries = value; }
    }
    private int _retrySpanMs;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"retrySpanMs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retrySpanMs
    {
      get { return _retrySpanMs; }
      set { _retrySpanMs = value; }
    }
    private int _lastChanceRetrySpanMs;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"lastChanceRetrySpanMs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int lastChanceRetrySpanMs
    {
      get { return _lastChanceRetrySpanMs; }
      set { _lastChanceRetrySpanMs = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ModifyOrderCommandDTO")]
  public partial class ModifyOrderCommandDTO : global::ProtoBuf.IExtensible
  {
    public ModifyOrderCommandDTO() {}
    
    private int _command;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int command
    {
      get { return _command; }
      set { _command = value; }
    }
    private int _order;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private double _openPrice;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"openPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double openPrice
    {
      get { return _openPrice; }
      set { _openPrice = value; }
    }
    private double _stopLoss;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"stopLoss", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double stopLoss
    {
      get { return _stopLoss; }
      set { _stopLoss = value; }
    }
    private double _takeProfit;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"takeProfit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double takeProfit
    {
      get { return _takeProfit; }
      set { _takeProfit = value; }
    }
    private int _retries;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"retries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retries
    {
      get { return _retries; }
      set { _retries = value; }
    }
    private int _retrySpanMs;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"retrySpanMs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retrySpanMs
    {
      get { return _retrySpanMs; }
      set { _retrySpanMs = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CloseOrderCommandDTO")]
  public partial class CloseOrderCommandDTO : global::ProtoBuf.IExtensible
  {
    public CloseOrderCommandDTO() {}
    
    private int _command;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int command
    {
      get { return _command; }
      set { _command = value; }
    }
    private int _order;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private int _retries;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"retries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retries
    {
      get { return _retries; }
      set { _retries = value; }
    }
    private int _retrySpanMs;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"retrySpanMs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retrySpanMs
    {
      get { return _retrySpanMs; }
      set { _retrySpanMs = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CloseOrderByCommandDTO")]
  public partial class CloseOrderByCommandDTO : global::ProtoBuf.IExtensible
  {
    public CloseOrderByCommandDTO() {}
    
    private int _command;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int command
    {
      get { return _command; }
      set { _command = value; }
    }
    private int _order;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private int _orderBy;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"orderBy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int orderBy
    {
      get { return _orderBy; }
      set { _orderBy = value; }
    }
    private int _retries;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"retries", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retries
    {
      get { return _retries; }
      set { _retries = value; }
    }
    private int _retrySpanMs;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"retrySpanMs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int retrySpanMs
    {
      get { return _retrySpanMs; }
      set { _retrySpanMs = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OrderInfoDTO")]
  public partial class OrderInfoDTO : global::ProtoBuf.IExtensible
  {
    public OrderInfoDTO() {}
    
    private int _order;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private string _symbol;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"symbol", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string symbol
    {
      get { return _symbol; }
      set { _symbol = value; }
    }
    private int _tradeCommand;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"tradeCommand", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tradeCommand
    {
      get { return _tradeCommand; }
      set { _tradeCommand = value; }
    }
    private double _volume;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"volume", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double volume
    {
      get { return _volume; }
      set { _volume = value; }
    }
    private double _openPrice;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"openPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double openPrice
    {
      get { return _openPrice; }
      set { _openPrice = value; }
    }
    private double _stopLoss;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"stopLoss", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double stopLoss
    {
      get { return _stopLoss; }
      set { _stopLoss = value; }
    }
    private double _takeProfit;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"takeProfit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double takeProfit
    {
      get { return _takeProfit; }
      set { _takeProfit = value; }
    }
    private double _closePrice;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"closePrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double closePrice
    {
      get { return _closePrice; }
      set { _closePrice = value; }
    }
    private double _profit;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"profit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double profit
    {
      get { return _profit; }
      set { _profit = value; }
    }
    private int _pointProfit;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"pointProfit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pointProfit
    {
      get { return _pointProfit; }
      set { _pointProfit = value; }
    }
    private int _openTime;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"openTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int openTime
    {
      get { return _openTime; }
      set { _openTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateOrdersDTO")]
  public partial class UpdateOrdersDTO : global::ProtoBuf.IExtensible
  {
    public UpdateOrdersDTO() {}
    
    private readonly global::System.Collections.Generic.List<Ultima.MT4.Packets.OrderInfoDTO> _orders = new global::System.Collections.Generic.List<Ultima.MT4.Packets.OrderInfoDTO>();
    [global::ProtoBuf.ProtoMember(1, Name=@"orders", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Ultima.MT4.Packets.OrderInfoDTO> orders
    {
      get { return _orders; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CommandResultDTO")]
  public partial class CommandResultDTO : global::ProtoBuf.IExtensible
  {
    public CommandResultDTO() {}
    
    private int _command;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int command
    {
      get { return _command; }
      set { _command = value; }
    }
    private int _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private int _order;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestHistoryDTO")]
  public partial class RequestHistoryDTO : global::ProtoBuf.IExtensible
  {
    public RequestHistoryDTO() {}
    
    private int _command;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int command
    {
      get { return _command; }
      set { _command = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HistoryOrderInfoDTO")]
  public partial class HistoryOrderInfoDTO : global::ProtoBuf.IExtensible
  {
    public HistoryOrderInfoDTO() {}
    
    private int _order;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int order
    {
      get { return _order; }
      set { _order = value; }
    }
    private string _symbol;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"symbol", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string symbol
    {
      get { return _symbol; }
      set { _symbol = value; }
    }
    private int _tradeCommand;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"tradeCommand", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int tradeCommand
    {
      get { return _tradeCommand; }
      set { _tradeCommand = value; }
    }
    private double _volume;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"volume", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double volume
    {
      get { return _volume; }
      set { _volume = value; }
    }
    private double _openPrice;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"openPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double openPrice
    {
      get { return _openPrice; }
      set { _openPrice = value; }
    }
    private double _stopLoss;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"stopLoss", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double stopLoss
    {
      get { return _stopLoss; }
      set { _stopLoss = value; }
    }
    private double _takeProfit;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"takeProfit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double takeProfit
    {
      get { return _takeProfit; }
      set { _takeProfit = value; }
    }
    private double _closePrice;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"closePrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double closePrice
    {
      get { return _closePrice; }
      set { _closePrice = value; }
    }
    private double _profit;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"profit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double profit
    {
      get { return _profit; }
      set { _profit = value; }
    }
    private int _pointProfit;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"pointProfit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int pointProfit
    {
      get { return _pointProfit; }
      set { _pointProfit = value; }
    }
    private int _openTime;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"openTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int openTime
    {
      get { return _openTime; }
      set { _openTime = value; }
    }
    private int _closeTime;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"closeTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int closeTime
    {
      get { return _closeTime; }
      set { _closeTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OrdersHistoryDTO")]
  public partial class OrdersHistoryDTO : global::ProtoBuf.IExtensible
  {
    public OrdersHistoryDTO() {}
    
    private int _command;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int command
    {
      get { return _command; }
      set { _command = value; }
    }
    private readonly global::System.Collections.Generic.List<Ultima.MT4.Packets.HistoryOrderInfoDTO> _orders = new global::System.Collections.Generic.List<Ultima.MT4.Packets.HistoryOrderInfoDTO>();
    [global::ProtoBuf.ProtoMember(2, Name=@"orders", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Ultima.MT4.Packets.HistoryOrderInfoDTO> orders
    {
      get { return _orders; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}