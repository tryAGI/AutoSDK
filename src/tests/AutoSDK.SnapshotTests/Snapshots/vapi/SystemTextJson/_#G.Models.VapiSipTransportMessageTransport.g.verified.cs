//HintName: G.Models.VapiSipTransportMessageTransport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transport type.
    /// </summary>
    public enum VapiSipTransportMessageTransport
    {
        /// <summary>
        /// 
        /// </summary>
        VapiSip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiSipTransportMessageTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiSipTransportMessageTransport value)
        {
            return value switch
            {
                VapiSipTransportMessageTransport.VapiSip => "vapi.sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiSipTransportMessageTransport? ToEnum(string value)
        {
            return value switch
            {
                "vapi.sip" => VapiSipTransportMessageTransport.VapiSip,
                _ => null,
            };
        }
    }
}