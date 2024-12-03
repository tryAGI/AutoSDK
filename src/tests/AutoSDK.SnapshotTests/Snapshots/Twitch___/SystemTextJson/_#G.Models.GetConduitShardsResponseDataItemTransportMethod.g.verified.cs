//HintName: G.Models.GetConduitShardsResponseDataItemTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  <br/>
    ///   <br/>
    /// * webhook<br/>
    /// * websocket
    /// </summary>
    public enum GetConduitShardsResponseDataItemTransportMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Websocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConduitShardsResponseDataItemTransportMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConduitShardsResponseDataItemTransportMethod value)
        {
            return value switch
            {
                GetConduitShardsResponseDataItemTransportMethod.Webhook => "webhook",
                GetConduitShardsResponseDataItemTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConduitShardsResponseDataItemTransportMethod? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => GetConduitShardsResponseDataItemTransportMethod.Webhook,
                "websocket" => GetConduitShardsResponseDataItemTransportMethod.Websocket,
                _ => null,
            };
        }
    }
}