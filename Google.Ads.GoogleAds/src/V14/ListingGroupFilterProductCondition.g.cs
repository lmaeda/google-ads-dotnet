// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/enums/listing_group_filter_product_condition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/enums/listing_group_filter_product_condition.proto</summary>
  public static partial class ListingGroupFilterProductConditionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/enums/listing_group_filter_product_condition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListingGroupFilterProductConditionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cktnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvbGlzdGluZ19ncm91",
            "cF9maWx0ZXJfcHJvZHVjdF9jb25kaXRpb24ucHJvdG8SHmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxNC5lbnVtcyKQAQomTGlzdGluZ0dyb3VwRmlsdGVyUHJv",
            "ZHVjdENvbmRpdGlvbkVudW0iZgoiTGlzdGluZ0dyb3VwRmlsdGVyUHJvZHVj",
            "dENvbmRpdGlvbhIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIHCgNO",
            "RVcQAhIPCgtSRUZVUkJJU0hFRBADEggKBFVTRUQQBEKBAgoiY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYxNC5lbnVtc0InTGlzdGluZ0dyb3VwRmlsdGVy",
            "UHJvZHVjdENvbmRpdGlvblByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTQvZW51bXM7ZW51",
            "bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTQuRW51bXPKAh5H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMTRcRW51bXPqAiJHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMTQ6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Enums.ListingGroupFilterProductConditionEnum), global::Google.Ads.GoogleAds.V14.Enums.ListingGroupFilterProductConditionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Enums.ListingGroupFilterProductConditionEnum.Types.ListingGroupFilterProductCondition) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Condition of a product offer.
  /// </summary>
  public sealed partial class ListingGroupFilterProductConditionEnum : pb::IMessage<ListingGroupFilterProductConditionEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListingGroupFilterProductConditionEnum> _parser = new pb::MessageParser<ListingGroupFilterProductConditionEnum>(() => new ListingGroupFilterProductConditionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListingGroupFilterProductConditionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Enums.ListingGroupFilterProductConditionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterProductConditionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterProductConditionEnum(ListingGroupFilterProductConditionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListingGroupFilterProductConditionEnum Clone() {
      return new ListingGroupFilterProductConditionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListingGroupFilterProductConditionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListingGroupFilterProductConditionEnum other) {
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
    public void MergeFrom(ListingGroupFilterProductConditionEnum other) {
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
    /// <summary>Container for nested types declared in the ListingGroupFilterProductConditionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the condition of a product offer.
      /// </summary>
      public enum ListingGroupFilterProductCondition {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The product condition is new.
        /// </summary>
        [pbr::OriginalName("NEW")] New = 2,
        /// <summary>
        /// The product condition is refurbished.
        /// </summary>
        [pbr::OriginalName("REFURBISHED")] Refurbished = 3,
        /// <summary>
        /// The product condition is used.
        /// </summary>
        [pbr::OriginalName("USED")] Used = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
