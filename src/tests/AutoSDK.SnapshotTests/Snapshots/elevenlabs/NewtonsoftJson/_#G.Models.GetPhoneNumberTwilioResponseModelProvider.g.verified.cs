//HintName: G.Models.GetPhoneNumberTwilioResponseModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Phone provider<br/>
    /// Default Value: twilio
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPhoneNumberTwilioResponseModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPhoneNumberTwilioResponseModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumberTwilioResponseModelProvider value)
        {
            return value switch
            {
                GetPhoneNumberTwilioResponseModelProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumberTwilioResponseModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => GetPhoneNumberTwilioResponseModelProvider.Twilio,
                _ => null,
            };
        }
    }
}