// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/resources/payments_account.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/resources/payments_account.proto</summary>
  public static partial class PaymentsAccountReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/resources/payments_account.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaymentsAccountReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvcmVzb3VyY2VzL3BheW1lbnRz",
            "X2FjY291bnQucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNC5yZXNv",
            "dXJjZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2ds",
            "ZS9hcGkvcmVzb3VyY2UucHJvdG8i2wQKD1BheW1lbnRzQWNjb3VudBJHCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJQjDgQQP6QSoKKGdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9QYXltZW50c0FjY291bnQSJQoTcGF5bWVudHNfYWNjb3VudF9p",
            "ZBgIIAEoCUID4EEDSACIAQESFgoEbmFtZRgJIAEoCUID4EEDSAGIAQESHwoN",
            "Y3VycmVuY3lfY29kZRgKIAEoCUID4EEDSAKIAQESJQoTcGF5bWVudHNfcHJv",
            "ZmlsZV9pZBgLIAEoCUID4EEDSAOIAQESLwodc2Vjb25kYXJ5X3BheW1lbnRz",
            "X3Byb2ZpbGVfaWQYDCABKAlCA+BBA0gEiAEBEk8KF3BheWluZ19tYW5hZ2Vy",
            "X2N1c3RvbWVyGA0gASgJQingQQP6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlz",
            "LmNvbS9DdXN0b21lckgFiAEBOm3qQWoKKGdvb2dsZWFkcy5nb29nbGVhcGlz",
            "LmNvbS9QYXltZW50c0FjY291bnQSPmN1c3RvbWVycy97Y3VzdG9tZXJfaWR9",
            "L3BheW1lbnRzQWNjb3VudHMve3BheW1lbnRzX2FjY291bnRfaWR9QhYKFF9w",
            "YXltZW50c19hY2NvdW50X2lkQgcKBV9uYW1lQhAKDl9jdXJyZW5jeV9jb2Rl",
            "QhYKFF9wYXltZW50c19wcm9maWxlX2lkQiAKHl9zZWNvbmRhcnlfcGF5bWVu",
            "dHNfcHJvZmlsZV9pZEIaChhfcGF5aW5nX21hbmFnZXJfY3VzdG9tZXJChgIK",
            "JmNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTQucmVzb3VyY2VzQhRQYXlt",
            "ZW50c0FjY291bnRQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE0L3Jlc291cmNlcztyZXNv",
            "dXJjZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTQuUmVzb3Vy",
            "Y2VzygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE0XFJlc291cmNlc+oCJkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Resources.PaymentsAccount), global::Google.Ads.GoogleAds.V14.Resources.PaymentsAccount.Parser, new[]{ "ResourceName", "PaymentsAccountId", "Name", "CurrencyCode", "PaymentsProfileId", "SecondaryPaymentsProfileId", "PayingManagerCustomer" }, new[]{ "PaymentsAccountId", "Name", "CurrencyCode", "PaymentsProfileId", "SecondaryPaymentsProfileId", "PayingManagerCustomer" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A payments account, which can be used to set up billing for an Ads customer.
  /// </summary>
  public sealed partial class PaymentsAccount : pb::IMessage<PaymentsAccount>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PaymentsAccount> _parser = new pb::MessageParser<PaymentsAccount>(() => new PaymentsAccount());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PaymentsAccount> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Resources.PaymentsAccountReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PaymentsAccount() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PaymentsAccount(PaymentsAccount other) : this() {
      resourceName_ = other.resourceName_;
      paymentsAccountId_ = other.paymentsAccountId_;
      name_ = other.name_;
      currencyCode_ = other.currencyCode_;
      paymentsProfileId_ = other.paymentsProfileId_;
      secondaryPaymentsProfileId_ = other.secondaryPaymentsProfileId_;
      payingManagerCustomer_ = other.payingManagerCustomer_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PaymentsAccount Clone() {
      return new PaymentsAccount(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the payments account.
    /// PaymentsAccount resource names have the form:
    ///
    /// `customers/{customer_id}/paymentsAccounts/{payments_account_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payments_account_id" field.</summary>
    public const int PaymentsAccountIdFieldNumber = 8;
    private readonly static string PaymentsAccountIdDefaultValue = "";

    private string paymentsAccountId_;
    /// <summary>
    /// Output only. A 16 digit ID used to identify a payments account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PaymentsAccountId {
      get { return paymentsAccountId_ ?? PaymentsAccountIdDefaultValue; }
      set {
        paymentsAccountId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "payments_account_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPaymentsAccountId {
      get { return paymentsAccountId_ != null; }
    }
    /// <summary>Clears the value of the "payments_account_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPaymentsAccountId() {
      paymentsAccountId_ = null;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 9;
    private readonly static string NameDefaultValue = "";

    private string name_;
    /// <summary>
    /// Output only. The name of the payments account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? NameDefaultValue; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 10;
    private readonly static string CurrencyCodeDefaultValue = "";

    private string currencyCode_;
    /// <summary>
    /// Output only. The currency code of the payments account.
    /// A subset of the currency codes derived from the ISO 4217 standard is
    /// supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CurrencyCode {
      get { return currencyCode_ ?? CurrencyCodeDefaultValue; }
      set {
        currencyCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "currency_code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCurrencyCode {
      get { return currencyCode_ != null; }
    }
    /// <summary>Clears the value of the "currency_code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCurrencyCode() {
      currencyCode_ = null;
    }

    /// <summary>Field number for the "payments_profile_id" field.</summary>
    public const int PaymentsProfileIdFieldNumber = 11;
    private readonly static string PaymentsProfileIdDefaultValue = "";

    private string paymentsProfileId_;
    /// <summary>
    /// Output only. A 12 digit ID used to identify the payments profile associated
    /// with the payments account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PaymentsProfileId {
      get { return paymentsProfileId_ ?? PaymentsProfileIdDefaultValue; }
      set {
        paymentsProfileId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "payments_profile_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPaymentsProfileId {
      get { return paymentsProfileId_ != null; }
    }
    /// <summary>Clears the value of the "payments_profile_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPaymentsProfileId() {
      paymentsProfileId_ = null;
    }

    /// <summary>Field number for the "secondary_payments_profile_id" field.</summary>
    public const int SecondaryPaymentsProfileIdFieldNumber = 12;
    private readonly static string SecondaryPaymentsProfileIdDefaultValue = "";

    private string secondaryPaymentsProfileId_;
    /// <summary>
    /// Output only. A secondary payments profile ID present in uncommon
    /// situations, for example, when a sequential liability agreement has been
    /// arranged.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SecondaryPaymentsProfileId {
      get { return secondaryPaymentsProfileId_ ?? SecondaryPaymentsProfileIdDefaultValue; }
      set {
        secondaryPaymentsProfileId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "secondary_payments_profile_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSecondaryPaymentsProfileId {
      get { return secondaryPaymentsProfileId_ != null; }
    }
    /// <summary>Clears the value of the "secondary_payments_profile_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSecondaryPaymentsProfileId() {
      secondaryPaymentsProfileId_ = null;
    }

    /// <summary>Field number for the "paying_manager_customer" field.</summary>
    public const int PayingManagerCustomerFieldNumber = 13;
    private readonly static string PayingManagerCustomerDefaultValue = "";

    private string payingManagerCustomer_;
    /// <summary>
    /// Output only. Paying manager of this payment account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PayingManagerCustomer {
      get { return payingManagerCustomer_ ?? PayingManagerCustomerDefaultValue; }
      set {
        payingManagerCustomer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "paying_manager_customer" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPayingManagerCustomer {
      get { return payingManagerCustomer_ != null; }
    }
    /// <summary>Clears the value of the "paying_manager_customer" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPayingManagerCustomer() {
      payingManagerCustomer_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PaymentsAccount);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PaymentsAccount other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (PaymentsAccountId != other.PaymentsAccountId) return false;
      if (Name != other.Name) return false;
      if (CurrencyCode != other.CurrencyCode) return false;
      if (PaymentsProfileId != other.PaymentsProfileId) return false;
      if (SecondaryPaymentsProfileId != other.SecondaryPaymentsProfileId) return false;
      if (PayingManagerCustomer != other.PayingManagerCustomer) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasPaymentsAccountId) hash ^= PaymentsAccountId.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (HasCurrencyCode) hash ^= CurrencyCode.GetHashCode();
      if (HasPaymentsProfileId) hash ^= PaymentsProfileId.GetHashCode();
      if (HasSecondaryPaymentsProfileId) hash ^= SecondaryPaymentsProfileId.GetHashCode();
      if (HasPayingManagerCustomer) hash ^= PayingManagerCustomer.GetHashCode();
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
      if (HasPaymentsAccountId) {
        output.WriteRawTag(66);
        output.WriteString(PaymentsAccountId);
      }
      if (HasName) {
        output.WriteRawTag(74);
        output.WriteString(Name);
      }
      if (HasCurrencyCode) {
        output.WriteRawTag(82);
        output.WriteString(CurrencyCode);
      }
      if (HasPaymentsProfileId) {
        output.WriteRawTag(90);
        output.WriteString(PaymentsProfileId);
      }
      if (HasSecondaryPaymentsProfileId) {
        output.WriteRawTag(98);
        output.WriteString(SecondaryPaymentsProfileId);
      }
      if (HasPayingManagerCustomer) {
        output.WriteRawTag(106);
        output.WriteString(PayingManagerCustomer);
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
      if (HasPaymentsAccountId) {
        output.WriteRawTag(66);
        output.WriteString(PaymentsAccountId);
      }
      if (HasName) {
        output.WriteRawTag(74);
        output.WriteString(Name);
      }
      if (HasCurrencyCode) {
        output.WriteRawTag(82);
        output.WriteString(CurrencyCode);
      }
      if (HasPaymentsProfileId) {
        output.WriteRawTag(90);
        output.WriteString(PaymentsProfileId);
      }
      if (HasSecondaryPaymentsProfileId) {
        output.WriteRawTag(98);
        output.WriteString(SecondaryPaymentsProfileId);
      }
      if (HasPayingManagerCustomer) {
        output.WriteRawTag(106);
        output.WriteString(PayingManagerCustomer);
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
      if (HasPaymentsAccountId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PaymentsAccountId);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasCurrencyCode) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyCode);
      }
      if (HasPaymentsProfileId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PaymentsProfileId);
      }
      if (HasSecondaryPaymentsProfileId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SecondaryPaymentsProfileId);
      }
      if (HasPayingManagerCustomer) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PayingManagerCustomer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PaymentsAccount other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasPaymentsAccountId) {
        PaymentsAccountId = other.PaymentsAccountId;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasCurrencyCode) {
        CurrencyCode = other.CurrencyCode;
      }
      if (other.HasPaymentsProfileId) {
        PaymentsProfileId = other.PaymentsProfileId;
      }
      if (other.HasSecondaryPaymentsProfileId) {
        SecondaryPaymentsProfileId = other.SecondaryPaymentsProfileId;
      }
      if (other.HasPayingManagerCustomer) {
        PayingManagerCustomer = other.PayingManagerCustomer;
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
          case 66: {
            PaymentsAccountId = input.ReadString();
            break;
          }
          case 74: {
            Name = input.ReadString();
            break;
          }
          case 82: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 90: {
            PaymentsProfileId = input.ReadString();
            break;
          }
          case 98: {
            SecondaryPaymentsProfileId = input.ReadString();
            break;
          }
          case 106: {
            PayingManagerCustomer = input.ReadString();
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
          case 66: {
            PaymentsAccountId = input.ReadString();
            break;
          }
          case 74: {
            Name = input.ReadString();
            break;
          }
          case 82: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 90: {
            PaymentsProfileId = input.ReadString();
            break;
          }
          case 98: {
            SecondaryPaymentsProfileId = input.ReadString();
            break;
          }
          case 106: {
            PayingManagerCustomer = input.ReadString();
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
