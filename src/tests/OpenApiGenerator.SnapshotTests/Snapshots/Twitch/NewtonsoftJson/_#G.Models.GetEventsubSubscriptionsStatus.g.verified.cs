//HintName: G.Models.GetEventsubSubscriptionsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetEventsubSubscriptionsStatus
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEventsubSubscriptionsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEventsubSubscriptionsStatus value)
        {
            return value switch
            {
                GetEventsubSubscriptionsStatus.Enabled => "enabled",
                GetEventsubSubscriptionsStatus.WebhookCallbackVerificationPending => "webhook_callback_verification_pending",
                GetEventsubSubscriptionsStatus.WebhookCallbackVerificationFailed => "webhook_callback_verification_failed",
                GetEventsubSubscriptionsStatus.NotificationFailuresExceeded => "notification_failures_exceeded",
                GetEventsubSubscriptionsStatus.AuthorizationRevoked => "authorization_revoked",
                GetEventsubSubscriptionsStatus.ModeratorRemoved => "moderator_removed",
                GetEventsubSubscriptionsStatus.UserRemoved => "user_removed",
                GetEventsubSubscriptionsStatus.VersionRemoved => "version_removed",
                GetEventsubSubscriptionsStatus.BetaMaintenance => "beta_maintenance",
                GetEventsubSubscriptionsStatus.WebsocketDisconnected => "websocket_disconnected",
                GetEventsubSubscriptionsStatus.WebsocketFailedPingPong => "websocket_failed_ping_pong",
                GetEventsubSubscriptionsStatus.WebsocketReceivedInboundTraffic => "websocket_received_inbound_traffic",
                GetEventsubSubscriptionsStatus.WebsocketConnectionUnused => "websocket_connection_unused",
                GetEventsubSubscriptionsStatus.WebsocketInternalError => "websocket_internal_error",
                GetEventsubSubscriptionsStatus.WebsocketNetworkTimeout => "websocket_network_timeout",
                GetEventsubSubscriptionsStatus.WebsocketNetworkError => "websocket_network_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEventsubSubscriptionsStatus ToEnum(string value)
        {
            return value switch
            {
                "enabled" => GetEventsubSubscriptionsStatus.Enabled,
                "webhook_callback_verification_pending" => GetEventsubSubscriptionsStatus.WebhookCallbackVerificationPending,
                "webhook_callback_verification_failed" => GetEventsubSubscriptionsStatus.WebhookCallbackVerificationFailed,
                "notification_failures_exceeded" => GetEventsubSubscriptionsStatus.NotificationFailuresExceeded,
                "authorization_revoked" => GetEventsubSubscriptionsStatus.AuthorizationRevoked,
                "moderator_removed" => GetEventsubSubscriptionsStatus.ModeratorRemoved,
                "user_removed" => GetEventsubSubscriptionsStatus.UserRemoved,
                "version_removed" => GetEventsubSubscriptionsStatus.VersionRemoved,
                "beta_maintenance" => GetEventsubSubscriptionsStatus.BetaMaintenance,
                "websocket_disconnected" => GetEventsubSubscriptionsStatus.WebsocketDisconnected,
                "websocket_failed_ping_pong" => GetEventsubSubscriptionsStatus.WebsocketFailedPingPong,
                "websocket_received_inbound_traffic" => GetEventsubSubscriptionsStatus.WebsocketReceivedInboundTraffic,
                "websocket_connection_unused" => GetEventsubSubscriptionsStatus.WebsocketConnectionUnused,
                "websocket_internal_error" => GetEventsubSubscriptionsStatus.WebsocketInternalError,
                "websocket_network_timeout" => GetEventsubSubscriptionsStatus.WebsocketNetworkTimeout,
                "websocket_network_error" => GetEventsubSubscriptionsStatus.WebsocketNetworkError,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}