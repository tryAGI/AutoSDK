//HintName: G.Models.TransportCostProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransportCostProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="daily")]
        Daily,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="telnyx")]
        Telnyx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi.sip")]
        VapiSip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi.websocket")]
        VapiWebsocket,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vonage")]
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransportCostProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransportCostProvider value)
        {
            return value switch
            {
                TransportCostProvider.Daily => "daily",
                TransportCostProvider.Telnyx => "telnyx",
                TransportCostProvider.Twilio => "twilio",
                TransportCostProvider.VapiSip => "vapi.sip",
                TransportCostProvider.VapiWebsocket => "vapi.websocket",
                TransportCostProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransportCostProvider? ToEnum(string value)
        {
            return value switch
            {
                "daily" => TransportCostProvider.Daily,
                "telnyx" => TransportCostProvider.Telnyx,
                "twilio" => TransportCostProvider.Twilio,
                "vapi.sip" => TransportCostProvider.VapiSip,
                "vapi.websocket" => TransportCostProvider.VapiWebsocket,
                "vonage" => TransportCostProvider.Vonage,
                _ => null,
            };
        }
    }
}