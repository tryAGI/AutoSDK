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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConduitShardsBodyShardsTransportMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConduitShardsBodyShardsTransportMethod value)
        {
            return value switch
            {
                UpdateConduitShardsBodyShardsTransportMethod.Webhook => "webhook",
                UpdateConduitShardsBodyShardsTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConduitShardsBodyShardsTransportMethod? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => UpdateConduitShardsBodyShardsTransportMethod.Webhook,
                "websocket" => UpdateConduitShardsBodyShardsTransportMethod.Websocket,
                _ => null,
            };
        }
    }
}