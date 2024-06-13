//HintName: G.Models.EventSubSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventSubSubscription
    {
        /// <summary>
        /// An ID that identifies the subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.EventSubSubscriptionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EventSubSubscriptionStatus Status { get; set; }

        /// <summary>
        /// The subscription's type. See [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.EventSubSubscriptionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EventSubSubscriptionType Type { get; set; }

        /// <summary>
        /// The version number that identifies this definition of the subscription's data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// The subscription's parameter values. This is a string-encoded JSON object whose contents are determined by the subscription type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Condition { get; set; }

        /// <summary>
        /// The date and time (in RFC3339 format) of when the subscription was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The transport details used to send the notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EventSubSubscriptionTransport Transport { get; set; }

        /// <summary>
        /// The amount that the subscription counts against your limit. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}