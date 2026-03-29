//HintName: G.Models.PostWebhookSubscriptionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostWebhookSubscriptionsRequest
    {
        /// <summary>
        /// HTTPS URL to receive webhook events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// Array of event types to subscribe to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnabledEvents { get; set; }

        /// <summary>
        /// Webhook payload version<br/>
        /// Default Value: V3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostWebhookSubscriptionsRequestVersionJsonConverter))]
        public global::G.PostWebhookSubscriptionsRequestVersion? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWebhookSubscriptionsRequest" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// HTTPS URL to receive webhook events
        /// </param>
        /// <param name="enabledEvents">
        /// Array of event types to subscribe to
        /// </param>
        /// <param name="version">
        /// Webhook payload version<br/>
        /// Default Value: V3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostWebhookSubscriptionsRequest(
            string webhookUrl,
            global::System.Collections.Generic.IList<string> enabledEvents,
            global::G.PostWebhookSubscriptionsRequestVersion? version)
        {
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.EnabledEvents = enabledEvents ?? throw new global::System.ArgumentNullException(nameof(enabledEvents));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWebhookSubscriptionsRequest" /> class.
        /// </summary>
        public PostWebhookSubscriptionsRequest()
        {
        }
    }
}