//HintName: G.Models.UpdateConduitShardsBodyShardTransportMethod.g.cs

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
    public enum UpdateConduitShardsBodyShardTransportMethod
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
    public static class UpdateConduitShardsBodyShardTransportMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConduitShardsBodyShardTransportMethod value)
        {
            return value switch
            {
                UpdateConduitShardsBodyShardTransportMethod.Webhook => "webhook",
                UpdateConduitShardsBodyShardTransportMethod.Websocket => "websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConduitShardsBodyShardTransportMethod? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => UpdateConduitShardsBodyShardTransportMethod.Webhook,
                "websocket" => UpdateConduitShardsBodyShardTransportMethod.Websocket,
                _ => null,
            };
        }
    }
}