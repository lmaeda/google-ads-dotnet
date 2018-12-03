// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/ad_customizer_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/ad_customizer_placeholder_field.proto</summary>
  public static partial class AdCustomizerPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/ad_customizer_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdCustomizerPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9hZF9jdXN0b21pemVy",
            "X3BsYWNlaG9sZGVyX2ZpZWxkLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MC5lbnVtcyKOAQogQWRDdXN0b21pemVyUGxhY2Vob2xkZXJGaWVsZEVu",
            "dW0iagocQWRDdXN0b21pemVyUGxhY2Vob2xkZXJGaWVsZBIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARILCgdJTlRFR0VSEAISCQoFUFJJQ0UQAxII",
            "CgREQVRFEAQSCgoGU1RSSU5HEAVC0gEKIWNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MC5lbnVtc0IhQWRDdXN0b21pemVyUGxhY2Vob2xkZXJGaWVsZFBy",
            "b3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92MC9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYwLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjBcRW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.AdCustomizerPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V0.Enums.AdCustomizerPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.AdCustomizerPlaceholderFieldEnum.Types.AdCustomizerPlaceholderField) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Ad Customizer placeholder fields.
  /// </summary>
  public sealed partial class AdCustomizerPlaceholderFieldEnum : pb::IMessage<AdCustomizerPlaceholderFieldEnum> {
    private static readonly pb::MessageParser<AdCustomizerPlaceholderFieldEnum> _parser = new pb::MessageParser<AdCustomizerPlaceholderFieldEnum>(() => new AdCustomizerPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdCustomizerPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.AdCustomizerPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdCustomizerPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdCustomizerPlaceholderFieldEnum(AdCustomizerPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdCustomizerPlaceholderFieldEnum Clone() {
      return new AdCustomizerPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdCustomizerPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdCustomizerPlaceholderFieldEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdCustomizerPlaceholderFieldEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AdCustomizerPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Ad Customizers placeholder fields.
      /// </summary>
      public enum AdCustomizerPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: INT64. Integer value to be inserted.
        /// </summary>
        [pbr::OriginalName("INTEGER")] Integer = 2,
        /// <summary>
        /// Data Type: STRING. Price value to be inserted.
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 3,
        /// <summary>
        /// Data Type: DATE_TIME. Date value to be inserted.
        /// </summary>
        [pbr::OriginalName("DATE")] Date = 4,
        /// <summary>
        /// Data Type: STRING. String value to be inserted.
        /// </summary>
        [pbr::OriginalName("STRING")] String = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
