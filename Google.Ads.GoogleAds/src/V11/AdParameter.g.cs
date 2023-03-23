// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/ad_parameter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/ad_parameter.proto</summary>
  public static partial class AdParameterReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/ad_parameter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdParameterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2FkX3BhcmFt",
            "ZXRlci5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjExLnJlc291cmNl",
            "cxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2Fw",
            "aS9yZXNvdXJjZS5wcm90byKkAwoLQWRQYXJhbWV0ZXISQwoNcmVzb3VyY2Vf",
            "bmFtZRgBIAEoCUIs4EEF+kEmCiRnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "QWRQYXJhbWV0ZXISUgoSYWRfZ3JvdXBfY3JpdGVyaW9uGAUgASgJQjHgQQX6",
            "QSsKKWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwQ3JpdGVyaW9u",
            "SACIAQESIQoPcGFyYW1ldGVyX2luZGV4GAYgASgDQgPgQQVIAYgBARIbCg5p",
            "bnNlcnRpb25fdGV4dBgHIAEoCUgCiAEBOn7qQXsKJGdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9BZFBhcmFtZXRlchJTY3VzdG9tZXJzL3tjdXN0b21lcl9p",
            "ZH0vYWRQYXJhbWV0ZXJzL3thZF9ncm91cF9pZH1+e2NyaXRlcmlvbl9pZH1+",
            "e3BhcmFtZXRlcl9pbmRleH1CFQoTX2FkX2dyb3VwX2NyaXRlcmlvbkISChBf",
            "cGFyYW1ldGVyX2luZGV4QhEKD19pbnNlcnRpb25fdGV4dEKCAgomY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5yZXNvdXJjZXNCEEFkUGFyYW1ldGVy",
            "UHJvdG9QAVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3YxMS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FB",
            "qgIiR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjExLlJlc291cmNlc8oCIkdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYxMVxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMTE6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.AdParameter), global::Google.Ads.GoogleAds.V11.Resources.AdParameter.Parser, new[]{ "ResourceName", "AdGroupCriterion", "ParameterIndex", "InsertionText" }, new[]{ "AdGroupCriterion", "ParameterIndex", "InsertionText" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An ad parameter that is used to update numeric values (such as prices or
  /// inventory levels) in any text line of an ad (including URLs). There can
  /// be a maximum of two AdParameters per ad group criterion. (One with
  /// parameter_index = 1 and one with parameter_index = 2.)
  /// In the ad the parameters are referenced by a placeholder of the form
  /// "{param#:value}". For example, "{param1:$17}"
  /// </summary>
  public sealed partial class AdParameter : pb::IMessage<AdParameter>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdParameter> _parser = new pb::MessageParser<AdParameter>(() => new AdParameter());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdParameter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.AdParameterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdParameter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdParameter(AdParameter other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      adGroupCriterion_ = other.adGroupCriterion_;
      parameterIndex_ = other.parameterIndex_;
      insertionText_ = other.insertionText_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdParameter Clone() {
      return new AdParameter(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad parameter.
    /// Ad parameter resource names have the form:
    ///
    /// `customers/{customer_id}/adParameters/{ad_group_id}~{criterion_id}~{parameter_index}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group_criterion" field.</summary>
    public const int AdGroupCriterionFieldNumber = 5;
    private string adGroupCriterion_;
    /// <summary>
    /// Immutable. The ad group criterion that this ad parameter belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroupCriterion {
      get { return adGroupCriterion_ ?? ""; }
      set {
        adGroupCriterion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group_criterion" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAdGroupCriterion {
      get { return adGroupCriterion_ != null; }
    }
    /// <summary>Clears the value of the "ad_group_criterion" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAdGroupCriterion() {
      adGroupCriterion_ = null;
    }

    /// <summary>Field number for the "parameter_index" field.</summary>
    public const int ParameterIndexFieldNumber = 6;
    private long parameterIndex_;
    /// <summary>
    /// Immutable. The unique index of this ad parameter. Must be either 1 or 2.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ParameterIndex {
      get { if ((_hasBits0 & 1) != 0) { return parameterIndex_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        parameterIndex_ = value;
      }
    }
    /// <summary>Gets whether the "parameter_index" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasParameterIndex {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "parameter_index" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearParameterIndex() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "insertion_text" field.</summary>
    public const int InsertionTextFieldNumber = 7;
    private string insertionText_;
    /// <summary>
    /// Numeric value to insert into the ad text. The following restrictions
    ///  apply:
    ///  - Can use comma or period as a separator, with an optional period or
    ///    comma (respectively) for fractional values. For example, 1,000,000.00
    ///    and 2.000.000,10 are valid.
    ///  - Can be prepended or appended with a currency symbol. For example,
    ///    $99.99 is valid.
    ///  - Can be prepended or appended with a currency code. For example, 99.99USD
    ///    and EUR200 are valid.
    ///  - Can use '%'. For example, 1.0% and 1,0% are valid.
    ///  - Can use plus or minus. For example, -10.99 and 25+ are valid.
    ///  - Can use '/' between two numbers. For example 4/1 and 0.95/0.45 are
    ///    valid.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string InsertionText {
      get { return insertionText_ ?? ""; }
      set {
        insertionText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "insertion_text" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasInsertionText {
      get { return insertionText_ != null; }
    }
    /// <summary>Clears the value of the "insertion_text" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearInsertionText() {
      insertionText_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdParameter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdParameter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroupCriterion != other.AdGroupCriterion) return false;
      if (ParameterIndex != other.ParameterIndex) return false;
      if (InsertionText != other.InsertionText) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasAdGroupCriterion) hash ^= AdGroupCriterion.GetHashCode();
      if (HasParameterIndex) hash ^= ParameterIndex.GetHashCode();
      if (HasInsertionText) hash ^= InsertionText.GetHashCode();
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
      if (HasAdGroupCriterion) {
        output.WriteRawTag(42);
        output.WriteString(AdGroupCriterion);
      }
      if (HasParameterIndex) {
        output.WriteRawTag(48);
        output.WriteInt64(ParameterIndex);
      }
      if (HasInsertionText) {
        output.WriteRawTag(58);
        output.WriteString(InsertionText);
      }
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
      if (HasAdGroupCriterion) {
        output.WriteRawTag(42);
        output.WriteString(AdGroupCriterion);
      }
      if (HasParameterIndex) {
        output.WriteRawTag(48);
        output.WriteInt64(ParameterIndex);
      }
      if (HasInsertionText) {
        output.WriteRawTag(58);
        output.WriteString(InsertionText);
      }
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
      if (HasAdGroupCriterion) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroupCriterion);
      }
      if (HasParameterIndex) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ParameterIndex);
      }
      if (HasInsertionText) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InsertionText);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdParameter other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasAdGroupCriterion) {
        AdGroupCriterion = other.AdGroupCriterion;
      }
      if (other.HasParameterIndex) {
        ParameterIndex = other.ParameterIndex;
      }
      if (other.HasInsertionText) {
        InsertionText = other.InsertionText;
      }
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
          case 42: {
            AdGroupCriterion = input.ReadString();
            break;
          }
          case 48: {
            ParameterIndex = input.ReadInt64();
            break;
          }
          case 58: {
            InsertionText = input.ReadString();
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
          case 42: {
            AdGroupCriterion = input.ReadString();
            break;
          }
          case 48: {
            ParameterIndex = input.ReadInt64();
            break;
          }
          case 58: {
            InsertionText = input.ReadString();
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
