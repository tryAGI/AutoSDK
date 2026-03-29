//HintName: G.Models.CallPhoneCallProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the call.<br/>
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    public enum CallPhoneCallProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Telnyx,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Vapi,
        /// <summary>
        /// 
        /// </summary>
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallPhoneCallProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallPhoneCallProvider value)
        {
            return value switch
            {
                CallPhoneCallProvider.Telnyx => "telnyx",
                CallPhoneCallProvider.Twilio => "twilio",
                CallPhoneCallProvider.Vapi => "vapi",
                CallPhoneCallProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallPhoneCallProvider? ToEnum(string value)
        {
            return value switch
            {
                "telnyx" => CallPhoneCallProvider.Telnyx,
                "twilio" => CallPhoneCallProvider.Twilio,
                "vapi" => CallPhoneCallProvider.Vapi,
                "vonage" => CallPhoneCallProvider.Vonage,
                _ => null,
            };
        }
    }
}