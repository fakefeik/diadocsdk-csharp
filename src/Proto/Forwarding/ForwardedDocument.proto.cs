//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Forwarding/ForwardedDocument.proto
// Note: requires additional types generated from: Timestamp.proto
// Note: requires additional types generated from: DocumentId.proto
// Note: requires additional types generated from: Docflow/DocumentWithDocflow.proto
namespace Diadoc.Api.Proto.Forwarding
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ForwardedDocumentId")]
  public partial class ForwardedDocumentId : global::ProtoBuf.IExtensible
  {
    public ForwardedDocumentId() {}
    

    private string _FromBoxId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"FromBoxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string FromBoxId
    {
      get { return _FromBoxId; }
      set { _FromBoxId = value; }
    }

    private Diadoc.Api.Proto.DocumentId _DocumentId = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DocumentId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.DocumentId DocumentId
    {
      get { return _DocumentId; }
      set { _DocumentId = value; }
    }

    private string _ForwardEventId = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ForwardEventId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ForwardEventId
    {
      get { return _ForwardEventId; }
      set { _ForwardEventId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ForwardedDocument")]
  public partial class ForwardedDocument : global::ProtoBuf.IExtensible
  {
    public ForwardedDocument() {}
    

    private Diadoc.Api.Proto.Timestamp _ForwardTimestamp = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ForwardTimestamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp ForwardTimestamp
    {
      get { return _ForwardTimestamp; }
      set { _ForwardTimestamp = value; }
    }

    private Diadoc.Api.Proto.Forwarding.ForwardedDocumentId _ForwardedDocumentId = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ForwardedDocumentId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Forwarding.ForwardedDocumentId ForwardedDocumentId
    {
      get { return _ForwardedDocumentId; }
      set { _ForwardedDocumentId = value; }
    }

    private Diadoc.Api.Proto.Docflow.DocumentWithDocflow _DocumentWithDocflow = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DocumentWithDocflow", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.DocumentWithDocflow DocumentWithDocflow
    {
      get { return _DocumentWithDocflow; }
      set { _DocumentWithDocflow = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}