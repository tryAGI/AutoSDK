//HintName: G.Models.PhoneNumberResponsePhoneNumberType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the phone number.<br/>
    /// Example: retell-twilio
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberResponsePhoneNumberType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retell-telnyx")]
        RetellTelnyx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retell-twilio")]
        RetellTwilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberResponsePhoneNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberResponsePhoneNumberType value)
        {
            return value switch
            {
                PhoneNumberResponsePhoneNumberType.Custom => "custom",
                PhoneNumberResponsePhoneNumberType.RetellTelnyx => "retell-telnyx",
                PhoneNumberResponsePhoneNumberType.RetellTwilio => "retell-twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberResponsePhoneNumberType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PhoneNumberResponsePhoneNumberType.Custom,
                "retell-telnyx" => PhoneNumberResponsePhoneNumberType.RetellTelnyx,
                "retell-twilio" => PhoneNumberResponsePhoneNumberType.RetellTwilio,
                _ => null,
            };
        }
    }
}