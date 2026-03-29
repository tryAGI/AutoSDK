//HintName: G.Models.CallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inboundPhoneCall")]
        InboundPhoneCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="outboundPhoneCall")]
        OutboundPhoneCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapi.websocketCall")]
        VapiWebsocketCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webCall")]
        WebCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallType value)
        {
            return value switch
            {
                CallType.InboundPhoneCall => "inboundPhoneCall",
                CallType.OutboundPhoneCall => "outboundPhoneCall",
                CallType.VapiWebsocketCall => "vapi.websocketCall",
                CallType.WebCall => "webCall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallType? ToEnum(string value)
        {
            return value switch
            {
                "inboundPhoneCall" => CallType.InboundPhoneCall,
                "outboundPhoneCall" => CallType.OutboundPhoneCall,
                "vapi.websocketCall" => CallType.VapiWebsocketCall,
                "webCall" => CallType.WebCall,
                _ => null,
            };
        }
    }
}