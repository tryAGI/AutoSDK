//HintName: G.Models.EventSubSubscriptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The subscription's status. The subscriber receives events only for **enabled** subscriptions. Possible values are:  
    ///   
    /// * enabled — The subscription is enabled.
    /// * webhook\_callback\_verification\_pending — The subscription is pending verification of the specified callback URL.
    /// * webhook\_callback\_verification\_failed — The specified callback URL failed verification.
    /// * notification\_failures\_exceeded — The notification delivery failure rate was too high.
    /// * authorization\_revoked — The authorization was revoked for one or more users specified in the **Condition** object.
    /// * moderator\_removed — The moderator that authorized the subscription is no longer one of the broadcaster's moderators.
    /// * user\_removed — One of the users specified in the **Condition** object was removed.
    /// * version\_removed — The subscription to subscription type and version is no longer supported.
    /// * beta\_maintenance — The subscription to the beta subscription type was removed due to maintenance.
    /// * websocket\_disconnected — The client closed the connection.
    /// * websocket\_failed\_ping\_pong — The client failed to respond to a ping message.
    /// * websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).
    /// * websocket\_connection\_unused — The client failed to subscribe to events within the required time.
    /// * websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.
    /// * websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.
    /// * websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EventSubSubscriptionStatus
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
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_revoked")]
        AuthorizationRevoked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moderator_removed")]
        ModeratorRemoved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_removed")]
        UserRemoved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="version_removed")]
        VersionRemoved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="beta_maintenance")]
        BetaMaintenance,
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
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_connection_unused")]
        WebsocketConnectionUnused,
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
}