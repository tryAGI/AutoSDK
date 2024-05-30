//HintName: G.Models.GetConduitShardsResponseDataStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shard status. The subscriber receives events only for enabled shards. Possible values are:  
    ///   
    /// * enabled — The shard is enabled.
    /// * webhook\_callback\_verification\_pending — The shard is pending verification of the specified callback URL.
    /// * webhook\_callback\_verification\_failed — The specified callback URL failed verification.
    /// * notification\_failures\_exceeded — The notification delivery failure rate was too high.
    /// * websocket\_disconnected — The client closed the connection.
    /// * websocket\_failed\_ping\_pong — The client failed to respond to a ping message.
    /// * websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).
    /// * websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.
    /// * websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.
    /// * websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConduitShardsResponseDataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook_callback_verification_pending")]
        WebhookCallbackVerificationPending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook_callback_verification_failed")]
        WebhookCallbackVerificationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="notification_failures_exceeded")]
        NotificationFailuresExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_disconnected")]
        WebsocketDisconnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_failed_ping_pong")]
        WebsocketFailedPingPong,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_received_inbound_traffic")]
        WebsocketReceivedInboundTraffic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_internal_error")]
        WebsocketInternalError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_network_timeout")]
        WebsocketNetworkTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_network_error")]
        WebsocketNetworkError,
    }

    public static class GetConduitShardsResponseDataStatusExtensions
    {
        public static string ToValueString(this GetConduitShardsResponseDataStatus value)
        {
            return value switch
            {
                GetConduitShardsResponseDataStatus.Enabled => "enabled",
                GetConduitShardsResponseDataStatus.WebhookCallbackVerificationPending => "webhook_callback_verification_pending",
                GetConduitShardsResponseDataStatus.WebhookCallbackVerificationFailed => "webhook_callback_verification_failed",
                GetConduitShardsResponseDataStatus.NotificationFailuresExceeded => "notification_failures_exceeded",
                GetConduitShardsResponseDataStatus.WebsocketDisconnected => "websocket_disconnected",
                GetConduitShardsResponseDataStatus.WebsocketFailedPingPong => "websocket_failed_ping_pong",
                GetConduitShardsResponseDataStatus.WebsocketReceivedInboundTraffic => "websocket_received_inbound_traffic",
                GetConduitShardsResponseDataStatus.WebsocketInternalError => "websocket_internal_error",
                GetConduitShardsResponseDataStatus.WebsocketNetworkTimeout => "websocket_network_timeout",
                GetConduitShardsResponseDataStatus.WebsocketNetworkError => "websocket_network_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetConduitShardsResponseDataStatus ToEnum(string value)
        {
            return value switch
            {
                "enabled" => GetConduitShardsResponseDataStatus.Enabled,
                "webhook_callback_verification_pending" => GetConduitShardsResponseDataStatus.WebhookCallbackVerificationPending,
                "webhook_callback_verification_failed" => GetConduitShardsResponseDataStatus.WebhookCallbackVerificationFailed,
                "notification_failures_exceeded" => GetConduitShardsResponseDataStatus.NotificationFailuresExceeded,
                "websocket_disconnected" => GetConduitShardsResponseDataStatus.WebsocketDisconnected,
                "websocket_failed_ping_pong" => GetConduitShardsResponseDataStatus.WebsocketFailedPingPong,
                "websocket_received_inbound_traffic" => GetConduitShardsResponseDataStatus.WebsocketReceivedInboundTraffic,
                "websocket_internal_error" => GetConduitShardsResponseDataStatus.WebsocketInternalError,
                "websocket_network_timeout" => GetConduitShardsResponseDataStatus.WebsocketNetworkTimeout,
                "websocket_network_error" => GetConduitShardsResponseDataStatus.WebsocketNetworkError,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetConduitShardsResponseDataStatus ToEnum(int value)
        {
            return value switch
            {
                0 => GetConduitShardsResponseDataStatus.Enabled,
                1 => GetConduitShardsResponseDataStatus.WebhookCallbackVerificationPending,
                2 => GetConduitShardsResponseDataStatus.WebhookCallbackVerificationFailed,
                3 => GetConduitShardsResponseDataStatus.NotificationFailuresExceeded,
                4 => GetConduitShardsResponseDataStatus.WebsocketDisconnected,
                5 => GetConduitShardsResponseDataStatus.WebsocketFailedPingPong,
                6 => GetConduitShardsResponseDataStatus.WebsocketReceivedInboundTraffic,
                7 => GetConduitShardsResponseDataStatus.WebsocketInternalError,
                8 => GetConduitShardsResponseDataStatus.WebsocketNetworkTimeout,
                9 => GetConduitShardsResponseDataStatus.WebsocketNetworkError,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}