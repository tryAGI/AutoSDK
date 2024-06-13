//HintName: G.Models.GetConduitShardsResponseDataStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shard status. The subscriber receives events only for enabled shards. Possible values are:  <br/>
    ///   <br/>
    /// * enabled — The shard is enabled.<br/>
    /// * webhook\_callback\_verification\_pending — The shard is pending verification of the specified callback URL.<br/>
    /// * webhook\_callback\_verification\_failed — The specified callback URL failed verification.<br/>
    /// * notification\_failures\_exceeded — The notification delivery failure rate was too high.<br/>
    /// * websocket\_disconnected — The client closed the connection.<br/>
    /// * websocket\_failed\_ping\_pong — The client failed to respond to a ping message.<br/>
    /// * websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).<br/>
    /// * websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.<br/>
    /// * websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.<br/>
    /// * websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.
    /// </summary>
    public enum GetConduitShardsResponseDataStatus
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConduitShardsResponseDataStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConduitShardsResponseDataStatus? ToEnum(string value)
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
                _ => null,
            };
        }
    }
}