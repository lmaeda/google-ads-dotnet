// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/resources/ad_group_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/resources/ad_group_asset.proto</summary>
  public static partial class AdGroupAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/resources/ad_group_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvcmVzb3VyY2VzL2FkX2dyb3Vw",
            "X2Fzc2V0LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTQucmVzb3Vy",
            "Y2VzGjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvY29tbW9uL2Fzc2V0X3Bv",
            "bGljeS5wcm90bxo1Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE0L2VudW1zL2Fz",
            "c2V0X2ZpZWxkX3R5cGUucHJvdG8aPmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Yx",
            "NC9lbnVtcy9hc3NldF9saW5rX3ByaW1hcnlfc3RhdHVzLnByb3RvGkVnb29n",
            "bGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvYXNzZXRfbGlua19wcmltYXJ5",
            "X3N0YXR1c19yZWFzb24ucHJvdG8aNmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Yx",
            "NC9lbnVtcy9hc3NldF9saW5rX3N0YXR1cy5wcm90bxoxZ29vZ2xlL2Fkcy9n",
            "b29nbGVhZHMvdjE0L2VudW1zL2Fzc2V0X3NvdXJjZS5wcm90bxofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJj",
            "ZS5wcm90byKmBwoMQWRHcm91cEFzc2V0EkQKDXJlc291cmNlX25hbWUYASAB",
            "KAlCLeBBBfpBJwolZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBB",
            "c3NldBI9CghhZF9ncm91cBgCIAEoCUIr4EEC4EEF+kEiCiBnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vQWRHcm91cBI4CgVhc3NldBgDIAEoCUIp4EEC4EEF",
            "+kEgCh5nb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXQSXQoKZmllbGRf",
            "dHlwZRgEIAEoDjJBLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNC5lbnVtcy5B",
            "c3NldEZpZWxkVHlwZUVudW0uQXNzZXRGaWVsZFR5cGVCBuBBAuBBBRJQCgZz",
            "b3VyY2UYBiABKA4yOy5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTQuZW51bXMu",
            "QXNzZXRTb3VyY2VFbnVtLkFzc2V0U291cmNlQgPgQQMSUwoGc3RhdHVzGAUg",
            "ASgOMkMuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE0LmVudW1zLkFzc2V0TGlu",
            "a1N0YXR1c0VudW0uQXNzZXRMaW5rU3RhdHVzEm4KDnByaW1hcnlfc3RhdHVz",
            "GAcgASgOMlEuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE0LmVudW1zLkFzc2V0",
            "TGlua1ByaW1hcnlTdGF0dXNFbnVtLkFzc2V0TGlua1ByaW1hcnlTdGF0dXNC",
            "A+BBAxJjChZwcmltYXJ5X3N0YXR1c19kZXRhaWxzGAggAygLMj4uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE0LmNvbW1vbi5Bc3NldExpbmtQcmltYXJ5U3Rh",
            "dHVzRGV0YWlsc0ID4EEDEoIBChZwcmltYXJ5X3N0YXR1c19yZWFzb25zGAkg",
            "AygOMl0uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE0LmVudW1zLkFzc2V0TGlu",
            "a1ByaW1hcnlTdGF0dXNSZWFzb25FbnVtLkFzc2V0TGlua1ByaW1hcnlTdGF0",
            "dXNSZWFzb25CA+BBAzp36kF0CiVnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "QWRHcm91cEFzc2V0EktjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9hZEdyb3Vw",
            "QXNzZXRzL3thZF9ncm91cF9pZH1+e2Fzc2V0X2lkfX57ZmllbGRfdHlwZX1C",
            "gwIKJmNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTQucmVzb3VyY2VzQhFB",
            "ZEdyb3VwQXNzZXRQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE0L3Jlc291cmNlcztyZXNv",
            "dXJjZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTQuUmVzb3Vy",
            "Y2VzygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE0XFJlc291cmNlc+oCJkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V14.Common.AssetPolicyReflection.Descriptor, global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusReasonReflection.Descriptor, global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V14.Enums.AssetSourceReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Resources.AdGroupAsset), global::Google.Ads.GoogleAds.V14.Resources.AdGroupAsset.Parser, new[]{ "ResourceName", "AdGroup", "Asset", "FieldType", "Source", "Status", "PrimaryStatus", "PrimaryStatusDetails", "PrimaryStatusReasons" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between an ad group and an asset.
  /// </summary>
  public sealed partial class AdGroupAsset : pb::IMessage<AdGroupAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAsset> _parser = new pb::MessageParser<AdGroupAsset>(() => new AdGroupAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Resources.AdGroupAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAsset(AdGroupAsset other) : this() {
      resourceName_ = other.resourceName_;
      adGroup_ = other.adGroup_;
      asset_ = other.asset_;
      fieldType_ = other.fieldType_;
      source_ = other.source_;
      status_ = other.status_;
      primaryStatus_ = other.primaryStatus_;
      primaryStatusDetails_ = other.primaryStatusDetails_.Clone();
      primaryStatusReasons_ = other.primaryStatusReasons_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAsset Clone() {
      return new AdGroupAsset(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group asset.
    /// AdGroupAsset resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 2;
    private string adGroup_ = "";
    /// <summary>
    /// Required. Immutable. The ad group to which the asset is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 3;
    private string asset_ = "";
    /// <summary>
    /// Required. Immutable. The asset which is linked to the ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "field_type" field.</summary>
    public const int FieldTypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType fieldType_ = global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified;
    /// <summary>
    /// Required. Immutable. Role that the asset takes under the linked ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType FieldType {
      get { return fieldType_; }
      set {
        fieldType_ = value;
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource source_ = global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource.Unspecified;
    /// <summary>
    /// Output only. Source of the adgroup asset link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus status_ = global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified;
    /// <summary>
    /// Status of the ad group asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "primary_status" field.</summary>
    public const int PrimaryStatusFieldNumber = 7;
    private global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus primaryStatus_ = global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified;
    /// <summary>
    /// Output only. Provides the PrimaryStatus of this asset link.
    /// Primary status is meant essentially to differentiate between the plain
    /// "status" field, which has advertiser set values of enabled, paused, or
    /// removed.  The primary status takes into account other signals (for assets
    /// its mainly policy and quality approvals) to come up with a more
    /// comprehensive status to indicate its serving state.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus PrimaryStatus {
      get { return primaryStatus_; }
      set {
        primaryStatus_ = value;
      }
    }

    /// <summary>Field number for the "primary_status_details" field.</summary>
    public const int PrimaryStatusDetailsFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V14.Common.AssetLinkPrimaryStatusDetails> _repeated_primaryStatusDetails_codec
        = pb::FieldCodec.ForMessage(66, global::Google.Ads.GoogleAds.V14.Common.AssetLinkPrimaryStatusDetails.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V14.Common.AssetLinkPrimaryStatusDetails> primaryStatusDetails_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V14.Common.AssetLinkPrimaryStatusDetails>();
    /// <summary>
    /// Output only. Provides the details of the primary status and its associated
    /// reasons.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V14.Common.AssetLinkPrimaryStatusDetails> PrimaryStatusDetails {
      get { return primaryStatusDetails_; }
    }

    /// <summary>Field number for the "primary_status_reasons" field.</summary>
    public const int PrimaryStatusReasonsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason> _repeated_primaryStatusReasons_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason> primaryStatusReasons_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason>();
    /// <summary>
    /// Output only. Provides a list of reasons for why an asset is not serving or
    /// not serving at full capacity.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusReasonEnum.Types.AssetLinkPrimaryStatusReason> PrimaryStatusReasons {
      get { return primaryStatusReasons_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroup != other.AdGroup) return false;
      if (Asset != other.Asset) return false;
      if (FieldType != other.FieldType) return false;
      if (Source != other.Source) return false;
      if (Status != other.Status) return false;
      if (PrimaryStatus != other.PrimaryStatus) return false;
      if(!primaryStatusDetails_.Equals(other.primaryStatusDetails_)) return false;
      if(!primaryStatusReasons_.Equals(other.primaryStatusReasons_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (AdGroup.Length != 0) hash ^= AdGroup.GetHashCode();
      if (Asset.Length != 0) hash ^= Asset.GetHashCode();
      if (FieldType != global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) hash ^= FieldType.GetHashCode();
      if (Source != global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) hash ^= Source.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) hash ^= PrimaryStatus.GetHashCode();
      hash ^= primaryStatusDetails_.GetHashCode();
      hash ^= primaryStatusReasons_.GetHashCode();
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
      if (AdGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdGroup);
      }
      if (Asset.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (Source != global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Source);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) PrimaryStatus);
      }
      primaryStatusDetails_.WriteTo(output, _repeated_primaryStatusDetails_codec);
      primaryStatusReasons_.WriteTo(output, _repeated_primaryStatusReasons_codec);
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
      if (AdGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdGroup);
      }
      if (Asset.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (Source != global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Source);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) PrimaryStatus);
      }
      primaryStatusDetails_.WriteTo(ref output, _repeated_primaryStatusDetails_codec);
      primaryStatusReasons_.WriteTo(ref output, _repeated_primaryStatusReasons_codec);
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
      if (AdGroup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (Asset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldType);
      }
      if (Source != global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Source);
      }
      if (Status != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PrimaryStatus);
      }
      size += primaryStatusDetails_.CalculateSize(_repeated_primaryStatusDetails_codec);
      size += primaryStatusReasons_.CalculateSize(_repeated_primaryStatusReasons_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdGroupAsset other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AdGroup.Length != 0) {
        AdGroup = other.AdGroup;
      }
      if (other.Asset.Length != 0) {
        Asset = other.Asset;
      }
      if (other.FieldType != global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        FieldType = other.FieldType;
      }
      if (other.Source != global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        Source = other.Source;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.PrimaryStatus != global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus.Unspecified) {
        PrimaryStatus = other.PrimaryStatus;
      }
      primaryStatusDetails_.Add(other.primaryStatusDetails_);
      primaryStatusReasons_.Add(other.primaryStatusReasons_);
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
          case 18: {
            AdGroup = input.ReadString();
            break;
          }
          case 26: {
            Asset = input.ReadString();
            break;
          }
          case 32: {
            FieldType = (global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
            break;
          }
          case 48: {
            Source = (global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource) input.ReadEnum();
            break;
          }
          case 56: {
            PrimaryStatus = (global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus) input.ReadEnum();
            break;
          }
          case 66: {
            primaryStatusDetails_.AddEntriesFrom(input, _repeated_primaryStatusDetails_codec);
            break;
          }
          case 74:
          case 72: {
            primaryStatusReasons_.AddEntriesFrom(input, _repeated_primaryStatusReasons_codec);
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
          case 18: {
            AdGroup = input.ReadString();
            break;
          }
          case 26: {
            Asset = input.ReadString();
            break;
          }
          case 32: {
            FieldType = (global::Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V14.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
            break;
          }
          case 48: {
            Source = (global::Google.Ads.GoogleAds.V14.Enums.AssetSourceEnum.Types.AssetSource) input.ReadEnum();
            break;
          }
          case 56: {
            PrimaryStatus = (global::Google.Ads.GoogleAds.V14.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus) input.ReadEnum();
            break;
          }
          case 66: {
            primaryStatusDetails_.AddEntriesFrom(ref input, _repeated_primaryStatusDetails_codec);
            break;
          }
          case 74:
          case 72: {
            primaryStatusReasons_.AddEntriesFrom(ref input, _repeated_primaryStatusReasons_codec);
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
