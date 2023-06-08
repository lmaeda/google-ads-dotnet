// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/enums/promotion_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/enums/promotion_placeholder_field.proto</summary>
  public static partial class PromotionPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/enums/promotion_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PromotionPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvcHJvbW90aW9uX3Bs",
            "YWNlaG9sZGVyX2ZpZWxkLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTQuZW51bXMi7gIKHVByb21vdGlvblBsYWNlaG9sZGVyRmllbGRFbnVtIswC",
            "ChlQcm9tb3Rpb25QbGFjZWhvbGRlckZpZWxkEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEhQKEFBST01PVElPTl9UQVJHRVQQAhIVChFESVNDT1VO",
            "VF9NT0RJRklFUhADEg8KC1BFUkNFTlRfT0ZGEAQSFAoQTU9ORVlfQU1PVU5U",
            "X09GRhAFEhIKDlBST01PVElPTl9DT0RFEAYSFgoST1JERVJTX09WRVJfQU1P",
            "VU5UEAcSEwoPUFJPTU9USU9OX1NUQVJUEAgSEQoNUFJPTU9USU9OX0VORBAJ",
            "EgwKCE9DQ0FTSU9OEAoSDgoKRklOQUxfVVJMUxALEhUKEUZJTkFMX01PQklM",
            "RV9VUkxTEAwSEAoMVFJBQ0tJTkdfVVJMEA0SDAoITEFOR1VBR0UQDhIUChBG",
            "SU5BTF9VUkxfU1VGRklYEA9C+AEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTQuZW51bXNCHlByb21vdGlvblBsYWNlaG9sZGVyRmllbGRQcm90b1AB",
            "WkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjE0L2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjE0LkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE0",
            "XEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE0OjpFbnVtc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Enums.PromotionPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V14.Enums.PromotionPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Enums.PromotionPlaceholderFieldEnum.Types.PromotionPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Promotion placeholder fields.
  /// </summary>
  public sealed partial class PromotionPlaceholderFieldEnum : pb::IMessage<PromotionPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PromotionPlaceholderFieldEnum> _parser = new pb::MessageParser<PromotionPlaceholderFieldEnum>(() => new PromotionPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PromotionPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Enums.PromotionPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromotionPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromotionPlaceholderFieldEnum(PromotionPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromotionPlaceholderFieldEnum Clone() {
      return new PromotionPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PromotionPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PromotionPlaceholderFieldEnum other) {
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
    public void MergeFrom(PromotionPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the PromotionPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Promotion placeholder fields.
      /// </summary>
      public enum PromotionPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The text that appears on the ad when the extension is
        /// shown.
        /// </summary>
        [pbr::OriginalName("PROMOTION_TARGET")] PromotionTarget = 2,
        /// <summary>
        /// Data Type: STRING. Lets you add "up to" phrase to the promotion,
        /// in case you have variable promotion rates.
        /// </summary>
        [pbr::OriginalName("DISCOUNT_MODIFIER")] DiscountModifier = 3,
        /// <summary>
        /// Data Type: INT64. Takes a value in micros, where 1 million micros
        /// represents 1%, and is shown as a percentage when rendered.
        /// </summary>
        [pbr::OriginalName("PERCENT_OFF")] PercentOff = 4,
        /// <summary>
        /// Data Type: MONEY. Requires a currency and an amount of money.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_OFF")] MoneyAmountOff = 5,
        /// <summary>
        /// Data Type: STRING. A string that the user enters to get the discount.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CODE")] PromotionCode = 6,
        /// <summary>
        /// Data Type: MONEY. A minimum spend before the user qualifies for the
        /// promotion.
        /// </summary>
        [pbr::OriginalName("ORDERS_OVER_AMOUNT")] OrdersOverAmount = 7,
        /// <summary>
        /// Data Type: DATE. The start date of the promotion.
        /// </summary>
        [pbr::OriginalName("PROMOTION_START")] PromotionStart = 8,
        /// <summary>
        /// Data Type: DATE. The end date of the promotion.
        /// </summary>
        [pbr::OriginalName("PROMOTION_END")] PromotionEnd = 9,
        /// <summary>
        /// Data Type: STRING. Describes the associated event for the promotion using
        /// one of the PromotionExtensionOccasion enum values, for example NEW_YEARS.
        /// </summary>
        [pbr::OriginalName("OCCASION")] Occasion = 10,
        /// <summary>
        /// Data Type: URL_LIST. Final URLs to be used in the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 11,
        /// <summary>
        /// Data Type: URL_LIST. Final mobile URLs for the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 12,
        /// <summary>
        /// Data Type: URL. Tracking template for the ad when using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 13,
        /// <summary>
        /// Data Type: STRING. A string represented by a language code for the
        /// promotion.
        /// </summary>
        [pbr::OriginalName("LANGUAGE")] Language = 14,
        /// <summary>
        /// Data Type: STRING. Final URL suffix for the ad when using parallel
        /// tracking.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SUFFIX")] FinalUrlSuffix = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
