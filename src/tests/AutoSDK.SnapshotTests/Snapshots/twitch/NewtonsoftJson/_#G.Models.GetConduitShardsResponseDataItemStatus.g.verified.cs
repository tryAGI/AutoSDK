﻿//HintName: G.Models.GetConduitShardsResponseDataItemStatus.g.cs

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
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConduitShardsResponseDataItemStatus
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConduitShardsResponseDataItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConduitShardsResponseDataItemStatus value)
        {
            return value switch
            {
                GetConduitShardsResponseDataItemStatus.Enabled => "enabled",
                GetConduitShardsResponseDataItemStatus.WebhookCallbackVerificationPending => "webhook_callback_verification_pending",
                GetConduitShardsResponseDataItemStatus.WebhookCallbackVerificationFailed => "webhook_callback_verification_failed",
                GetConduitShardsResponseDataItemStatus.NotificationFailuresExceeded => "notification_failures_exceeded",
                GetConduitShardsResponseDataItemStatus.WebsocketDisconnected => "websocket_disconnected",
                GetConduitShardsResponseDataItemStatus.WebsocketFailedPingPong => "websocket_failed_ping_pong",
                GetConduitShardsResponseDataItemStatus.WebsocketReceivedInboundTraffic => "websocket_received_inbound_traffic",
                GetConduitShardsResponseDataItemStatus.WebsocketInternalError => "websocket_internal_error",
                GetConduitShardsResponseDataItemStatus.WebsocketNetworkTimeout => "websocket_network_timeout",
                GetConduitShardsResponseDataItemStatus.WebsocketNetworkError => "websocket_network_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConduitShardsResponseDataItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => GetConduitShardsResponseDataItemStatus.Enabled,
                "webhook_callback_verification_pending" => GetConduitShardsResponseDataItemStatus.WebhookCallbackVerificationPending,
                "webhook_callback_verification_failed" => GetConduitShardsResponseDataItemStatus.WebhookCallbackVerificationFailed,
                "notification_failures_exceeded" => GetConduitShardsResponseDataItemStatus.NotificationFailuresExceeded,
                "websocket_disconnected" => GetConduitShardsResponseDataItemStatus.WebsocketDisconnected,
                "websocket_failed_ping_pong" => GetConduitShardsResponseDataItemStatus.WebsocketFailedPingPong,
                "websocket_received_inbound_traffic" => GetConduitShardsResponseDataItemStatus.WebsocketReceivedInboundTraffic,
                "websocket_internal_error" => GetConduitShardsResponseDataItemStatus.WebsocketInternalError,
                "websocket_network_timeout" => GetConduitShardsResponseDataItemStatus.WebsocketNetworkTimeout,
                "websocket_network_error" => GetConduitShardsResponseDataItemStatus.WebsocketNetworkError,
                _ => null,
            };
        }
    }
}