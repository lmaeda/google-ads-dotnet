// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/life_event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/life_event.proto</summary>
  public static partial class LifeEventReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/life_event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LifeEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2xpZmVfZXZl",
            "bnQucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5yZXNvdXJjZXMa",
            "RWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMS9jb21tb24vY3JpdGVyaW9uX2Nh",
            "dGVnb3J5X2F2YWlsYWJpbGl0eS5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9i",
            "ZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byKGAwoJ",
            "TGlmZUV2ZW50EkEKDXJlc291cmNlX25hbWUYASABKAlCKuBBA/pBJAoiZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0xpZmVFdmVudBIPCgJpZBgCIAEoA0ID",
            "4EEDEhEKBG5hbWUYAyABKAlCA+BBAxI6CgZwYXJlbnQYBCABKAlCKuBBA/pB",
            "JAoiZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0xpZmVFdmVudBIcCg9sYXVu",
            "Y2hlZF90b19hbGwYBSABKAhCA+BBAxJbCg5hdmFpbGFiaWxpdGllcxgGIAMo",
            "CzI+Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5jb21tb24uQ3JpdGVyaW9u",
            "Q2F0ZWdvcnlBdmFpbGFiaWxpdHlCA+BBAzpb6kFYCiJnb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vTGlmZUV2ZW50EjJjdXN0b21lcnMve2N1c3RvbWVyX2lk",
            "fS9saWZlRXZlbnRzL3tsaWZlX2V2ZW50X2lkfUKAAgomY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxMS5yZXNvdXJjZXNCDkxpZmVFdmVudFByb3RvUAFa",
            "S2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92MTEvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIkdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYxMS5SZXNvdXJjZXPKAiJHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMTFcUmVzb3VyY2Vz6gImR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjExOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V11.Common.CriterionCategoryAvailabilityReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.LifeEvent), global::Google.Ads.GoogleAds.V11.Resources.LifeEvent.Parser, new[]{ "ResourceName", "Id", "Name", "Parent", "LaunchedToAll", "Availabilities" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A life event: a particular interest-based vertical to be targeted to reach
  /// users when they are in the midst of important life milestones.
  /// </summary>
  public sealed partial class LifeEvent : pb::IMessage<LifeEvent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LifeEvent> _parser = new pb::MessageParser<LifeEvent>(() => new LifeEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LifeEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.LifeEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeEvent(LifeEvent other) : this() {
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      name_ = other.name_;
      parent_ = other.parent_;
      launchedToAll_ = other.launchedToAll_;
      availabilities_ = other.availabilities_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeEvent Clone() {
      return new LifeEvent(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the life event.
    /// Life event resource names have the form:
    ///
    /// `customers/{customer_id}/lifeEvents/{life_event_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private long id_;
    /// <summary>
    /// Output only. The ID of the life event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Output only. The name of the life event, for example,"Recently Moved"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 4;
    private string parent_ = "";
    /// <summary>
    /// Output only. The parent of the life_event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "launched_to_all" field.</summary>
    public const int LaunchedToAllFieldNumber = 5;
    private bool launchedToAll_;
    /// <summary>
    /// Output only. True if the life event is launched to all channels and locales.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LaunchedToAll {
      get { return launchedToAll_; }
      set {
        launchedToAll_ = value;
      }
    }

    /// <summary>Field number for the "availabilities" field.</summary>
    public const int AvailabilitiesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V11.Common.CriterionCategoryAvailability> _repeated_availabilities_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Ads.GoogleAds.V11.Common.CriterionCategoryAvailability.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Common.CriterionCategoryAvailability> availabilities_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Common.CriterionCategoryAvailability>();
    /// <summary>
    /// Output only. Availability information of the life event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Common.CriterionCategoryAvailability> Availabilities {
      get { return availabilities_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LifeEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LifeEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Parent != other.Parent) return false;
      if (LaunchedToAll != other.LaunchedToAll) return false;
      if(!availabilities_.Equals(other.availabilities_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (LaunchedToAll != false) hash ^= LaunchedToAll.GetHashCode();
      hash ^= availabilities_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Parent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Parent);
      }
      if (LaunchedToAll != false) {
        output.WriteRawTag(40);
        output.WriteBool(LaunchedToAll);
      }
      availabilities_.WriteTo(output, _repeated_availabilities_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Parent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Parent);
      }
      if (LaunchedToAll != false) {
        output.WriteRawTag(40);
        output.WriteBool(LaunchedToAll);
      }
      availabilities_.WriteTo(ref output, _repeated_availabilities_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (LaunchedToAll != false) {
        size += 1 + 1;
      }
      size += availabilities_.CalculateSize(_repeated_availabilities_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LifeEvent other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.LaunchedToAll != false) {
        LaunchedToAll = other.LaunchedToAll;
      }
      availabilities_.Add(other.availabilities_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Parent = input.ReadString();
            break;
          }
          case 40: {
            LaunchedToAll = input.ReadBool();
            break;
          }
          case 50: {
            availabilities_.AddEntriesFrom(input, _repeated_availabilities_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            Parent = input.ReadString();
            break;
          }
          case 40: {
            LaunchedToAll = input.ReadBool();
            break;
          }
          case 50: {
            availabilities_.AddEntriesFrom(ref input, _repeated_availabilities_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
