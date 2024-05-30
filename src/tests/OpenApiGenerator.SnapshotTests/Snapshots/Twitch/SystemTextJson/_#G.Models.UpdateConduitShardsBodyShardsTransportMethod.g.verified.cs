//HintName: G.Models.UpdateConduitShardsBodyShardsTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  
    ///   
    /// * webhook
    /// * websocket
    /// </summary>
    public enum UpdateConduitShardsBodyShardsTransportMethod
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

    public static class UpdateConduitShardsBodyShardsTransportMethodExtensions
    {
        public static string ToValueString(this UpdateConduitShardsBodyShardsTransportMethod value)
        {
            return value switch
            {
                UpdateConduitShardsBodyShardsTransportMethod.Webhook => "webhook",
                UpdateConduitShardsBodyShardsTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateConduitShardsBodyShardsTransportMethod ToEnum(string value)
        {
            return value switch
            {
                "webhook" => UpdateConduitShardsBodyShardsTransportMethod.Webhook,
                "websocket" => UpdateConduitShardsBodyShardsTransportMethod.Websocket,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateConduitShardsBodyShardsTransportMethod ToEnum(int value)
        {
            return value switch
            {
                0 => UpdateConduitShardsBodyShardsTransportMethod.Webhook,
                1 => UpdateConduitShardsBodyShardsTransportMethod.Websocket,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}