//HintName: G.Models.CreateEventSubSubscriptionBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventSubSubscriptionBody
    {
        /// <summary>
        /// The type of subscription to create. For a list of subscriptions that you can create, see [Subscription Types](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types). Set this field to the value in the **Name** column of the Subscription Types table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.CreateEventSubSubscriptionBodyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CreateEventSubSubscriptionBodyType Type { get; set; }

        /// <summary>
        /// The version number that identifies the definition of the subscription type that you want the response to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// A JSON object that contains the parameter values that are specific to the specified subscription type. For the object’s required and optional fields, see the subscription type’s documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Condition { get; set; }

        /// <summary>
        /// The transport details that you want Twitch to use when sending you notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CreateEventSubSubscriptionBodyTransport Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}