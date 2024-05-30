//HintName: G.Models.UpdateConduitShardsResponseDataStatus.g.cs

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
    public enum UpdateConduitShardsResponseDataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        WebhookCallbackVerificationPending,
        /// <summary>
        /// 
        /// </summary>
        WebhookCallbackVerificationFailed,
        /// <summary>
        /// 
        /// </summary>
        NotificationFailuresExceeded,
        /// <summary>
        /// 
        /// </summary>
        WebsocketDisconnected,
        /// <summary>
        /// 
        /// </summary>
        WebsocketFailedPingPong,
        /// <summary>
        /// 
        /// </summary>
        WebsocketReceivedInboundTraffic,
        /// <summary>
        /// 
        /// </summary>
        WebsocketInternalError,
        /// <summary>
        /// 
        /// </summary>
        WebsocketNetworkTimeout,
        /// <summary>
        /// 
        /// </summary>
        WebsocketNetworkError,
    }

    public static class UpdateConduitShardsResponseDataStatusExtensions
    {
        public static string ToValueString(this UpdateConduitShardsResponseDataStatus value)
        {
            return value switch
            {
                UpdateConduitShardsResponseDataStatus.Enabled => "enabled",
                UpdateConduitShardsResponseDataStatus.WebhookCallbackVerificationPending => "webhook_callback_verification_pending",
                UpdateConduitShardsResponseDataStatus.WebhookCallbackVerificationFailed => "webhook_callback_verification_failed",
                UpdateConduitShardsResponseDataStatus.NotificationFailuresExceeded => "notification_failures_exceeded",
                UpdateConduitShardsResponseDataStatus.WebsocketDisconnected => "websocket_disconnected",
                UpdateConduitShardsResponseDataStatus.WebsocketFailedPingPong => "websocket_failed_ping_pong",
                UpdateConduitShardsResponseDataStatus.WebsocketReceivedInboundTraffic => "websocket_received_inbound_traffic",
                UpdateConduitShardsResponseDataStatus.WebsocketInternalError => "websocket_internal_error",
                UpdateConduitShardsResponseDataStatus.WebsocketNetworkTimeout => "websocket_network_timeout",
                UpdateConduitShardsResponseDataStatus.WebsocketNetworkError => "websocket_network_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateConduitShardsResponseDataStatus ToEnum(string value)
        {
            return value switch
            {
                "enabled" => UpdateConduitShardsResponseDataStatus.Enabled,
                "webhook_callback_verification_pending" => UpdateConduitShardsResponseDataStatus.WebhookCallbackVerificationPending,
                "webhook_callback_verification_failed" => UpdateConduitShardsResponseDataStatus.WebhookCallbackVerificationFailed,
                "notification_failures_exceeded" => UpdateConduitShardsResponseDataStatus.NotificationFailuresExceeded,
                "websocket_disconnected" => UpdateConduitShardsResponseDataStatus.WebsocketDisconnected,
                "websocket_failed_ping_pong" => UpdateConduitShardsResponseDataStatus.WebsocketFailedPingPong,
                "websocket_received_inbound_traffic" => UpdateConduitShardsResponseDataStatus.WebsocketReceivedInboundTraffic,
                "websocket_internal_error" => UpdateConduitShardsResponseDataStatus.WebsocketInternalError,
                "websocket_network_timeout" => UpdateConduitShardsResponseDataStatus.WebsocketNetworkTimeout,
                "websocket_network_error" => UpdateConduitShardsResponseDataStatus.WebsocketNetworkError,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UpdateConduitShardsResponseDataStatus ToEnum(int value)
        {
            return value switch
            {
                0 => UpdateConduitShardsResponseDataStatus.Enabled,
                1 => UpdateConduitShardsResponseDataStatus.WebhookCallbackVerificationPending,
                2 => UpdateConduitShardsResponseDataStatus.WebhookCallbackVerificationFailed,
                3 => UpdateConduitShardsResponseDataStatus.NotificationFailuresExceeded,
                4 => UpdateConduitShardsResponseDataStatus.WebsocketDisconnected,
                5 => UpdateConduitShardsResponseDataStatus.WebsocketFailedPingPong,
                6 => UpdateConduitShardsResponseDataStatus.WebsocketReceivedInboundTraffic,
                7 => UpdateConduitShardsResponseDataStatus.WebsocketInternalError,
                8 => UpdateConduitShardsResponseDataStatus.WebsocketNetworkTimeout,
                9 => UpdateConduitShardsResponseDataStatus.WebsocketNetworkError,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}