//HintName: G.Models.TwilioSMSChatTransportType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of transport to use for sending the chat response.<br/>
    /// Currently supports 'twilio.sms' for SMS delivery via Twilio.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TwilioSMSChatTransportType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio.sms")]
        TwilioSms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioSMSChatTransportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioSMSChatTransportType value)
        {
            return value switch
            {
                TwilioSMSChatTransportType.TwilioSms => "twilio.sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioSMSChatTransportType? ToEnum(string value)
        {
            return value switch
            {
                "twilio.sms" => TwilioSMSChatTransportType.TwilioSms,
                _ => null,
            };
        }
    }
}