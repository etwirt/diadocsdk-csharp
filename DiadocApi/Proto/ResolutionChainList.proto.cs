//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ResolutionChainList.proto
namespace Diadoc.Api.Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResolutionChainList")]
  public partial class ResolutionChainList : global::ProtoBuf.IExtensible
  {
    public ResolutionChainList() {}
    
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.ResolutionChain> _ResolutionChains = new global::System.Collections.Generic.List<Diadoc.Api.Proto.ResolutionChain>();
    [global::ProtoBuf.ProtoMember(1, Name=@"ResolutionChains", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.ResolutionChain> ResolutionChains
    {
      get { return _ResolutionChains; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResolutionChain")]
  public partial class ResolutionChain : global::ProtoBuf.IExtensible
  {
    public ResolutionChain() {}
    
    private string _ChainId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ChainId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ChainId
    {
      get { return _ChainId; }
      set { _ChainId = value; }
    }
    private string _Name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}