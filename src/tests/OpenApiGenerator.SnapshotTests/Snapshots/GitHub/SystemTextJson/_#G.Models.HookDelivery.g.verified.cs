//HintName: G.Models.HookDelivery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Delivery made by a webhook.
    /// </summary>
    public sealed partial class HookDelivery
    {
        /// <summary>
        /// Unique identifier of the delivery.<br/>
        /// Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event).<br/>
        /// Example: 58474f00-b361-11eb-836d-0e4f3503ccbe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Guid { get; set; }

        /// <summary>
        /// Time when the delivery was delivered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivered_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DeliveredAt { get; set; }

        /// <summary>
        /// Whether the delivery is a redelivery.<br/>
        /// Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redelivery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Redelivery { get; set; }

        /// <summary>
        /// Time spent delivering.<br/>
        /// Example: 0.03
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Description of the status of the attempted delivery<br/>
        /// Example: failed to connect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Status code received when delivery was made.<br/>
        /// Example: 502
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// The event that triggered the delivery.<br/>
        /// Example: issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// The type of activity for the event that triggered the delivery.<br/>
        /// Example: opened
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Action { get; set; }

        /// <summary>
        /// The id of the GitHub App installation associated with this event.<br/>
        /// Example: 123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? InstallationId { get; set; }

        /// <summary>
        /// The id of the repository associated with this event.<br/>
        /// Example: 123
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? RepositoryId { get; set; }

        /// <summary>
        /// The URL target of the delivery.<br/>
        /// Example: https://www.example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HookDeliveryRequest Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HookDeliveryResponse Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}