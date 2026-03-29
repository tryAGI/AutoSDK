//HintName: G.Models.CallPhoneCallTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transport of the phone call.<br/>
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    public enum CallPhoneCallTransport
    {
        /// <summary>
        /// 
        /// </summary>
        Pstn,
        /// <summary>
        /// 
        /// </summary>
        Sip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallPhoneCallTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallPhoneCallTransport value)
        {
            return value switch
            {
                CallPhoneCallTransport.Pstn => "pstn",
                CallPhoneCallTransport.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallPhoneCallTransport? ToEnum(string value)
        {
            return value switch
            {
                "pstn" => CallPhoneCallTransport.Pstn,
                "sip" => CallPhoneCallTransport.Sip,
                _ => null,
            };
        }
    }
}