//HintName: G.Models.PatchWebhookSubscriptionsByIdResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWebhookSubscriptionsByIdResponse
    {
        /// <summary>
        /// Unique subscription ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Webhook destination URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookUrl { get; set; } = default!;

        /// <summary>
        /// Webhook payload version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PatchWebhookSubscriptionsByIdResponseVersionJsonConverter))]
        public global::G.PatchWebhookSubscriptionsByIdResponseVersion Version { get; set; } = default!;

        /// <summary>
        /// Subscribed event types
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EnabledEvents { get; set; } = default!;

        /// <summary>
        /// Masked signing secret (full secret only on create/rotate)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret", Required = global::Newtonsoft.Json.Required.Always)]
        public string Secret { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// ISO 8601 timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookSubscriptionsByIdResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique subscription ID
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook destination URL
        /// </param>
        /// <param name="version">
        /// Webhook payload version
        /// </param>
        /// <param name="enabledEvents">
        /// Subscribed event types
        /// </param>
        /// <param name="secret">
        /// Masked signing secret (full secret only on create/rotate)
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp
        /// </param>
        public PatchWebhookSubscriptionsByIdResponse(
            string id,
            string webhookUrl,
            global::G.PatchWebhookSubscriptionsByIdResponseVersion version,
            global::System.Collections.Generic.IList<string> enabledEvents,
            string secret,
            string createdAt,
            string updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.Version = version;
            this.EnabledEvents = enabledEvents ?? throw new global::System.ArgumentNullException(nameof(enabledEvents));
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookSubscriptionsByIdResponse" /> class.
        /// </summary>
        public PatchWebhookSubscriptionsByIdResponse()
        {
        }
    }
}