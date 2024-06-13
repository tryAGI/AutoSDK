//HintName: G.Models.GetConduitShardsResponseDataTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  <br/>
    ///   <br/>
    /// * webhook<br/>
    /// * websocket
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConduitShardsResponseDataTransportMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket")]
        Websocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConduitShardsResponseDataTransportMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConduitShardsResponseDataTransportMethod value)
        {
            return value switch
            {
                GetConduitShardsResponseDataTransportMethod.Webhook => "webhook",
                GetConduitShardsResponseDataTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConduitShardsResponseDataTransportMethod? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => GetConduitShardsResponseDataTransportMethod.Webhook,
                "websocket" => GetConduitShardsResponseDataTransportMethod.Websocket,
                _ => null,
            };
        }
    }
}