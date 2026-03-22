//HintName: G.Models.EventSubSubscriptionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The subscription's status. The subscriber receives events only for **enabled** subscriptions. Possible values are:  <br/>
    ///   <br/>
    /// * enabled — The subscription is enabled.<br/>
    /// * webhook\_callback\_verification\_pending — The subscription is pending verification of the specified callback URL.<br/>
    /// * webhook\_callback\_verification\_failed — The specified callback URL failed verification.<br/>
    /// * notification\_failures\_exceeded — The notification delivery failure rate was too high.<br/>
    /// * authorization\_revoked — The authorization was revoked for one or more users specified in the **Condition** object.<br/>
    /// * moderator\_removed — The moderator that authorized the subscription is no longer one of the broadcaster's moderators.<br/>
    /// * user\_removed — One of the users specified in the **Condition** object was removed.<br/>
    /// * version\_removed — The subscription to subscription type and version is no longer supported.<br/>
    /// * beta\_maintenance — The subscription to the beta subscription type was removed due to maintenance.<br/>
    /// * websocket\_disconnected — The client closed the connection.<br/>
    /// * websocket\_failed\_ping\_pong — The client failed to respond to a ping message.<br/>
    /// * websocket\_received\_inbound\_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).<br/>
    /// * websocket\_connection\_unused — The client failed to subscribe to events within the required time.<br/>
    /// * websocket\_internal\_error — The Twitch WebSocket server experienced an unexpected error.<br/>
    /// * websocket\_network\_timeout — The Twitch WebSocket server timed out writing the message to the client.<br/>
    /// * websocket\_network\_error — The Twitch WebSocket server experienced a network error writing the message to the client.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EventSubSubscriptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authorization_revoked")]
        AuthorizationRevoked,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="beta_maintenance")]
        BetaMaintenance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moderator_removed")]
        ModeratorRemoved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="notification_failures_exceeded")]
        NotificationFailuresExceeded,
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
        [global::System.Runtime.Serialization.EnumMember(Value="webhook_callback_verification_failed")]
        WebhookCallbackVerificationFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook_callback_verification_pending")]
        WebhookCallbackVerificationPending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_connection_unused")]
        WebsocketConnectionUnused,
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
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_internal_error")]
        WebsocketInternalError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_network_error")]
        WebsocketNetworkError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_network_timeout")]
        WebsocketNetworkTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="websocket_received_inbound_traffic")]
        WebsocketReceivedInboundTraffic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventSubSubscriptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventSubSubscriptionStatus value)
        {
            return value switch
            {
                EventSubSubscriptionStatus.AuthorizationRevoked => "authorization_revoked",
                EventSubSubscriptionStatus.BetaMaintenance => "beta_maintenance",
                EventSubSubscriptionStatus.Enabled => "enabled",
                EventSubSubscriptionStatus.ModeratorRemoved => "moderator_removed",
                EventSubSubscriptionStatus.NotificationFailuresExceeded => "notification_failures_exceeded",
                EventSubSubscriptionStatus.UserRemoved => "user_removed",
                EventSubSubscriptionStatus.VersionRemoved => "version_removed",
                EventSubSubscriptionStatus.WebhookCallbackVerificationFailed => "webhook_callback_verification_failed",
                EventSubSubscriptionStatus.WebhookCallbackVerificationPending => "webhook_callback_verification_pending",
                EventSubSubscriptionStatus.WebsocketConnectionUnused => "websocket_connection_unused",
                EventSubSubscriptionStatus.WebsocketDisconnected => "websocket_disconnected",
                EventSubSubscriptionStatus.WebsocketFailedPingPong => "websocket_failed_ping_pong",
                EventSubSubscriptionStatus.WebsocketInternalError => "websocket_internal_error",
                EventSubSubscriptionStatus.WebsocketNetworkError => "websocket_network_error",
                EventSubSubscriptionStatus.WebsocketNetworkTimeout => "websocket_network_timeout",
                EventSubSubscriptionStatus.WebsocketReceivedInboundTraffic => "websocket_received_inbound_traffic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventSubSubscriptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "authorization_revoked" => EventSubSubscriptionStatus.AuthorizationRevoked,
                "beta_maintenance" => EventSubSubscriptionStatus.BetaMaintenance,
                "enabled" => EventSubSubscriptionStatus.Enabled,
                "moderator_removed" => EventSubSubscriptionStatus.ModeratorRemoved,
                "notification_failures_exceeded" => EventSubSubscriptionStatus.NotificationFailuresExceeded,
                "user_removed" => EventSubSubscriptionStatus.UserRemoved,
                "version_removed" => EventSubSubscriptionStatus.VersionRemoved,
                "webhook_callback_verification_failed" => EventSubSubscriptionStatus.WebhookCallbackVerificationFailed,
                "webhook_callback_verification_pending" => EventSubSubscriptionStatus.WebhookCallbackVerificationPending,
                "websocket_connection_unused" => EventSubSubscriptionStatus.WebsocketConnectionUnused,
                "websocket_disconnected" => EventSubSubscriptionStatus.WebsocketDisconnected,
                "websocket_failed_ping_pong" => EventSubSubscriptionStatus.WebsocketFailedPingPong,
                "websocket_internal_error" => EventSubSubscriptionStatus.WebsocketInternalError,
                "websocket_network_error" => EventSubSubscriptionStatus.WebsocketNetworkError,
                "websocket_network_timeout" => EventSubSubscriptionStatus.WebsocketNetworkTimeout,
                "websocket_received_inbound_traffic" => EventSubSubscriptionStatus.WebsocketReceivedInboundTraffic,
                _ => null,
            };
        }
    }
}