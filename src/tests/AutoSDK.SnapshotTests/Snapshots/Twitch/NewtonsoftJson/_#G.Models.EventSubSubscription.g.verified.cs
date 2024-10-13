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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EventSubSubscriptionStatus Status { get; set; } = default!;

        /// <summary>
        /// The subscription's type. See [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EventSubSubscriptionType Type { get; set; } = default!;

        /// <summary>
        /// The version number that identifies this definition of the subscription's data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// The subscription's parameter values. This is a string-encoded JSON object whose contents are determined by the subscription type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition", Required = global::Newtonsoft.Json.Required.Always)]
        public object Condition { get; set; } = default!;

        /// <summary>
        /// The date and time (in RFC3339 format) of when the subscription was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The transport details used to send the notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EventSubSubscriptionTransport Transport { get; set; } = default!;

        /// <summary>
        /// The amount that the subscription counts against your limit. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.EventSubSubscription? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.EventSubSubscription>(
                json,
                jsonSerializerOptions);
        }

    }
}