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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Webhook destination URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// Webhook payload version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchWebhookSubscriptionsByIdResponseVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PatchWebhookSubscriptionsByIdResponseVersion Version { get; set; }

        /// <summary>
        /// Subscribed event types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnabledEvents { get; set; }

        /// <summary>
        /// Masked signing secret (full secret only on create/rotate)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// ISO 8601 timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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