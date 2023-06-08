// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/errors/asset_set_asset_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/errors/asset_set_asset_error.proto</summary>
  public static partial class AssetSetAssetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/errors/asset_set_asset_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetSetAssetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZXJyb3JzL2Fzc2V0X3NldF9h",
            "c3NldF9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE0LmVy",
            "cm9ycyLAAQoWQXNzZXRTZXRBc3NldEVycm9yRW51bSKlAQoSQXNzZXRTZXRB",
            "c3NldEVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhYKEklO",
            "VkFMSURfQVNTRVRfVFlQRRACEhoKFklOVkFMSURfQVNTRVRfU0VUX1RZUEUQ",
            "AxIaChZEVVBMSUNBVEVfRVhURVJOQUxfS0VZEAQSIQodUEFSRU5UX0xJTktB",
            "R0VfRE9FU19OT1RfRVhJU1QQBUL3AQojY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxNC5lcnJvcnNCF0Fzc2V0U2V0QXNzZXRFcnJvclByb3RvUAFaRWdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92MTQvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYxNC5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTRc",
            "RXJyb3Jz6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE0OjpFcnJvcnNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Errors.AssetSetAssetErrorEnum), global::Google.Ads.GoogleAds.V14.Errors.AssetSetAssetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Errors.AssetSetAssetErrorEnum.Types.AssetSetAssetError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset set asset errors.
  /// </summary>
  public sealed partial class AssetSetAssetErrorEnum : pb::IMessage<AssetSetAssetErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetSetAssetErrorEnum> _parser = new pb::MessageParser<AssetSetAssetErrorEnum>(() => new AssetSetAssetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetSetAssetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Errors.AssetSetAssetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetAssetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetAssetErrorEnum(AssetSetAssetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetSetAssetErrorEnum Clone() {
      return new AssetSetAssetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetSetAssetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetSetAssetErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetSetAssetErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AssetSetAssetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible asset set asset errors.
      /// </summary>
      public enum AssetSetAssetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The asset type is not eligible to be linked to the specific type of asset
        /// set.
        /// </summary>
        [pbr::OriginalName("INVALID_ASSET_TYPE")] InvalidAssetType = 2,
        /// <summary>
        /// The asset set type is not eligible to contain the specified type of
        /// assets.
        /// </summary>
        [pbr::OriginalName("INVALID_ASSET_SET_TYPE")] InvalidAssetSetType = 3,
        /// <summary>
        /// The asset contains duplicate external key with another asset in the asset
        /// set.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_EXTERNAL_KEY")] DuplicateExternalKey = 4,
        /// <summary>
        /// When attaching a Location typed Asset to a LocationGroup typed AssetSet,
        /// the AssetSetAsset linkage between the parent LocationSync AssetSet and
        /// the Asset doesn't exist.
        /// </summary>
        [pbr::OriginalName("PARENT_LINKAGE_DOES_NOT_EXIST")] ParentLinkageDoesNotExist = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
