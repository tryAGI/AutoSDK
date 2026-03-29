//HintName: G.Models.TwilioTransportMessageTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transport type.
    /// </summary>
    public enum TwilioTransportMessageTransport
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioTransportMessageTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioTransportMessageTransport value)
        {
            return value switch
            {
                TwilioTransportMessageTransport.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioTransportMessageTransport? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => TwilioTransportMessageTransport.Twilio,
                _ => null,
            };
        }
    }
}