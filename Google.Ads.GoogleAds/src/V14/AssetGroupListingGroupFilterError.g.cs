// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/errors/asset_group_listing_group_filter_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/errors/asset_group_listing_group_filter_error.proto</summary>
  public static partial class AssetGroupListingGroupFilterErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/errors/asset_group_listing_group_filter_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupListingGroupFilterErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZXJyb3JzL2Fzc2V0X2dyb3Vw",
            "X2xpc3RpbmdfZ3JvdXBfZmlsdGVyX2Vycm9yLnByb3RvEh9nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTQuZXJyb3JzIskECiVBc3NldEdyb3VwTGlzdGluZ0dy",
            "b3VwRmlsdGVyRXJyb3JFbnVtIp8ECiFBc3NldEdyb3VwTGlzdGluZ0dyb3Vw",
            "RmlsdGVyRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEQoN",
            "VFJFRV9UT09fREVFUBACEh0KGVVOSVRfQ0FOTk9UX0hBVkVfQ0hJTERSRU4Q",
            "AxIvCitTVUJESVZJU0lPTl9NVVNUX0hBVkVfRVZFUllUSElOR19FTFNFX0NI",
            "SUxEEAQSLQopRElGRkVSRU5UX0RJTUVOU0lPTl9UWVBFX0JFVFdFRU5fU0lC",
            "TElOR1MQBRIpCiVTQU1FX0RJTUVOU0lPTl9WQUxVRV9CRVRXRUVOX1NJQkxJ",
            "TkdTEAYSKQolU0FNRV9ESU1FTlNJT05fVFlQRV9CRVRXRUVOX0FOQ0VTVE9S",
            "UxAHEhIKDk1VTFRJUExFX1JPT1RTEAgSGwoXSU5WQUxJRF9ESU1FTlNJT05f",
            "VkFMVUUQCRIoCiRNVVNUX1JFRklORV9ISUVSQVJDSElDQUxfUEFSRU5UX1RZ",
            "UEUQChIkCiBJTlZBTElEX1BST0RVQ1RfQklERElOR19DQVRFR09SWRALEiUK",
            "IUNIQU5HSU5HX0NBU0VfVkFMVUVfV0lUSF9DSElMRFJFThAMEhwKGFNVQkRJ",
            "VklTSU9OX0hBU19DSElMRFJFThANEi4KKkNBTk5PVF9SRUZJTkVfSElFUkFS",
            "Q0hJQ0FMX0VWRVJZVEhJTkdfRUxTRRAOQoYCCiNjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjE0LmVycm9yc0ImQXNzZXRHcm91cExpc3RpbmdHcm91cEZp",
            "bHRlckVycm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNC9lcnJvcnM7ZXJyb3JzogID",
            "R0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE0LkVycm9yc8oCH0dvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYxNFxFcnJvcnPqAiNHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTQ6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Errors.AssetGroupListingGroupFilterErrorEnum), global::Google.Ads.GoogleAds.V14.Errors.AssetGroupListingGroupFilterErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Errors.AssetGroupListingGroupFilterErrorEnum.Types.AssetGroupListingGroupFilterError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset group listing group filter
  /// errors.
  /// </summary>
  public sealed partial class AssetGroupListingGroupFilterErrorEnum : pb::IMessage<AssetGroupListingGroupFilterErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroupListingGroupFilterErrorEnum> _parser = new pb::MessageParser<AssetGroupListingGroupFilterErrorEnum>(() => new AssetGroupListingGroupFilterErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroupListingGroupFilterErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Errors.AssetGroupListingGroupFilterErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupListingGroupFilterErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupListingGroupFilterErrorEnum(AssetGroupListingGroupFilterErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupListingGroupFilterErrorEnum Clone() {
      return new AssetGroupListingGroupFilterErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroupListingGroupFilterErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroupListingGroupFilterErrorEnum other) {
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
    public void MergeFrom(AssetGroupListingGroupFilterErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AssetGroupListingGroupFilterErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible asset group listing group filter errors.
      /// </summary>
      public enum AssetGroupListingGroupFilterError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Listing group tree is too deep.
        /// </summary>
        [pbr::OriginalName("TREE_TOO_DEEP")] TreeTooDeep = 2,
        /// <summary>
        /// Listing Group UNIT node cannot have children.
        /// </summary>
        [pbr::OriginalName("UNIT_CANNOT_HAVE_CHILDREN")] UnitCannotHaveChildren = 3,
        /// <summary>
        /// Listing Group SUBDIVISION node must have everything else child.
        /// </summary>
        [pbr::OriginalName("SUBDIVISION_MUST_HAVE_EVERYTHING_ELSE_CHILD")] SubdivisionMustHaveEverythingElseChild = 4,
        /// <summary>
        /// Dimension type of Listing Group must be the same as that of its siblings.
        /// </summary>
        [pbr::OriginalName("DIFFERENT_DIMENSION_TYPE_BETWEEN_SIBLINGS")] DifferentDimensionTypeBetweenSiblings = 5,
        /// <summary>
        /// The sibling Listing Groups target exactly the same dimension value.
        /// </summary>
        [pbr::OriginalName("SAME_DIMENSION_VALUE_BETWEEN_SIBLINGS")] SameDimensionValueBetweenSiblings = 6,
        /// <summary>
        /// The dimension type is the same as one of the ancestor Listing Groups.
        /// </summary>
        [pbr::OriginalName("SAME_DIMENSION_TYPE_BETWEEN_ANCESTORS")] SameDimensionTypeBetweenAncestors = 7,
        /// <summary>
        /// Each Listing Group tree must have a single root.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_ROOTS")] MultipleRoots = 8,
        /// <summary>
        /// Invalid Listing Group dimension value.
        /// </summary>
        [pbr::OriginalName("INVALID_DIMENSION_VALUE")] InvalidDimensionValue = 9,
        /// <summary>
        /// Hierarchical dimension must refine a dimension of the same type.
        /// </summary>
        [pbr::OriginalName("MUST_REFINE_HIERARCHICAL_PARENT_TYPE")] MustRefineHierarchicalParentType = 10,
        /// <summary>
        /// Invalid Product Bidding Category.
        /// </summary>
        [pbr::OriginalName("INVALID_PRODUCT_BIDDING_CATEGORY")] InvalidProductBiddingCategory = 11,
        /// <summary>
        /// Modifying case value is allowed only while updating the entire subtree at
        /// the same time.
        /// </summary>
        [pbr::OriginalName("CHANGING_CASE_VALUE_WITH_CHILDREN")] ChangingCaseValueWithChildren = 12,
        /// <summary>
        /// Subdivision node has children which must be removed first.
        /// </summary>
        [pbr::OriginalName("SUBDIVISION_HAS_CHILDREN")] SubdivisionHasChildren = 13,
        /// <summary>
        /// Dimension can't subdivide everything-else node in its own hierarchy.
        /// </summary>
        [pbr::OriginalName("CANNOT_REFINE_HIERARCHICAL_EVERYTHING_ELSE")] CannotRefineHierarchicalEverythingElse = 14,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
