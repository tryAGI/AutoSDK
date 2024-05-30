//HintName: G.Models.GetConduitShardsResponseDataTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  
    ///   
    /// * webhook
    /// * websocket
    /// </summary>
    public enum GetConduitShardsResponseDataTransportMethod
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

    public static class GetConduitShardsResponseDataTransportMethodExtensions
    {
        public static string ToValueString(this GetConduitShardsResponseDataTransportMethod value)
        {
            return value switch
            {
                GetConduitShardsResponseDataTransportMethod.Webhook => "webhook",
                GetConduitShardsResponseDataTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetConduitShardsResponseDataTransportMethod ToEnum(string value)
        {
            return value switch
            {
                "webhook" => GetConduitShardsResponseDataTransportMethod.Webhook,
                "websocket" => GetConduitShardsResponseDataTransportMethod.Websocket,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetConduitShardsResponseDataTransportMethod ToEnum(int value)
        {
            return value switch
            {
                0 => GetConduitShardsResponseDataTransportMethod.Webhook,
                1 => GetConduitShardsResponseDataTransportMethod.Websocket,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}