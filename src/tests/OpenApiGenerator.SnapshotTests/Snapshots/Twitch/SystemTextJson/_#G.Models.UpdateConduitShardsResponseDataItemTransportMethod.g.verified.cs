//HintName: G.Models.UpdateConduitShardsResponseDataItemTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  <br/>
    ///   <br/>
    /// * webhook<br/>
    /// * websocket
    /// </summary>
    public enum UpdateConduitShardsResponseDataItemTransportMethod
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
    public static class UpdateConduitShardsResponseDataItemTransportMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConduitShardsResponseDataItemTransportMethod value)
        {
            return value switch
            {
                UpdateConduitShardsResponseDataItemTransportMethod.Webhook => "webhook",
                UpdateConduitShardsResponseDataItemTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConduitShardsResponseDataItemTransportMethod? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => UpdateConduitShardsResponseDataItemTransportMethod.Webhook,
                "websocket" => UpdateConduitShardsResponseDataItemTransportMethod.Websocket,
                _ => null,
            };
        }
    }
}