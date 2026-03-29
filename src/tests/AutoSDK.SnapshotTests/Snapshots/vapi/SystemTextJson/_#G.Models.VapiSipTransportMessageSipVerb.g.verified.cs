//HintName: G.Models.VapiSipTransportMessageSipVerb.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the SIP verb to use. Must be one of INFO, MESSAGE, or NOTIFY.
    /// </summary>
    public enum VapiSipTransportMessageSipVerb
    {
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        Notify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiSipTransportMessageSipVerbExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiSipTransportMessageSipVerb value)
        {
            return value switch
            {
                VapiSipTransportMessageSipVerb.Info => "INFO",
                VapiSipTransportMessageSipVerb.Message => "MESSAGE",
                VapiSipTransportMessageSipVerb.Notify => "NOTIFY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiSipTransportMessageSipVerb? ToEnum(string value)
        {
            return value switch
            {
                "INFO" => VapiSipTransportMessageSipVerb.Info,
                "MESSAGE" => VapiSipTransportMessageSipVerb.Message,
                "NOTIFY" => VapiSipTransportMessageSipVerb.Notify,
                _ => null,
            };
        }
    }
}