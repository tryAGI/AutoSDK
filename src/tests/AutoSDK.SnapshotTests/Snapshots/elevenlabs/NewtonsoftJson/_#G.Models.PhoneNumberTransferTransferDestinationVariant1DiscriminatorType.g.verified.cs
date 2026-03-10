//HintName: G.Models.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberTransferTransferDestinationVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone")]
        Phone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone_dynamic_variable")]
        PhoneDynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_uri")]
        SipUri,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_uri_dynamic_variable")]
        SipUriDynamicVariable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberTransferTransferDestinationVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberTransferTransferDestinationVariant1DiscriminatorType value)
        {
            return value switch
            {
                PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.Phone => "phone",
                PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.PhoneDynamicVariable => "phone_dynamic_variable",
                PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUri => "sip_uri",
                PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUriDynamicVariable => "sip_uri_dynamic_variable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberTransferTransferDestinationVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "phone" => PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.Phone,
                "phone_dynamic_variable" => PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.PhoneDynamicVariable,
                "sip_uri" => PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUri,
                "sip_uri_dynamic_variable" => PhoneNumberTransferTransferDestinationVariant1DiscriminatorType.SipUriDynamicVariable,
                _ => null,
            };
        }
    }
}