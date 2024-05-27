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
    public abstract class GetConduitShardsResponseDataStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Enabled = "enabled";
        /// <summary>
        /// 
        /// </summary>
        public const string WebhookCallbackVerificationPending = "webhook_callback_verification_pending";
        /// <summary>
        /// 
        /// </summary>
        public const string WebhookCallbackVerificationFailed = "webhook_callback_verification_failed";
        /// <summary>
        /// 
        /// </summary>
        public const string NotificationFailuresExceeded = "notification_failures_exceeded";
        /// <summary>
        /// 
        /// </summary>
        public const string WebsocketDisconnected = "websocket_disconnected";
        /// <summary>
        /// 
        /// </summary>
        public const string WebsocketFailedPingPong = "websocket_failed_ping_pong";
        /// <summary>
        /// 
        /// </summary>
        public const string WebsocketReceivedInboundTraffic = "websocket_received_inbound_traffic";
        /// <summary>
        /// 
        /// </summary>
        public const string WebsocketInternalError = "websocket_internal_error";
        /// <summary>
        /// 
        /// </summary>
        public const string WebsocketNetworkTimeout = "websocket_network_timeout";
        /// <summary>
        /// 
        /// </summary>
        public const string WebsocketNetworkError = "websocket_network_error";
    }
}