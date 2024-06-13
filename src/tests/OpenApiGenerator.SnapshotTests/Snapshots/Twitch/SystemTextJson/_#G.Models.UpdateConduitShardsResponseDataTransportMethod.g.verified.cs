//HintName: G.Models.UpdateConduitShardsResponseDataTransportMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transport method. Possible values are:  <br/>
    ///   <br/>
    /// * webhook<br/>
    /// * websocket
    /// </summary>
    public enum UpdateConduitShardsResponseDataTransportMethod
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
    public static class UpdateConduitShardsResponseDataTransportMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConduitShardsResponseDataTransportMethod value)
        {
            return value switch
            {
                UpdateConduitShardsResponseDataTransportMethod.Webhook => "webhook",
                UpdateConduitShardsResponseDataTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConduitShardsResponseDataTransportMethod? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => UpdateConduitShardsResponseDataTransportMethod.Webhook,
                "websocket" => UpdateConduitShardsResponseDataTransportMethod.Websocket,
                _ => null,
            };
        }
    }
}