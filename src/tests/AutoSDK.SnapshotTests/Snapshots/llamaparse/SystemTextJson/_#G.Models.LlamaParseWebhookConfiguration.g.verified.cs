//HintName: G.Models.LlamaParseWebhookConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Webhook configuration for receiving parsing job notifications.<br/>
    /// Webhooks are called when specified events occur during job processing.<br/>
    /// Configure multiple webhook configurations to send to different endpoints.
    /// </summary>
    public sealed partial class LlamaParseWebhookConfiguration
    {
        /// <summary>
        /// HTTPS URL to receive webhook POST requests. Must be publicly accessible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in webhook requests. Use for authentication tokens or custom routing. Example: {'Authorization': 'Bearer xyz'}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_headers")]
        public object? WebhookHeaders { get; set; }

        /// <summary>
        /// Events that trigger this webhook. Options: 'parse.success' (job completed), 'parse.failure' (job failed), 'parse.partial' (some pages failed). If not specified, webhook fires for all events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events")]
        public global::System.Collections.Generic.IList<string>? WebhookEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseWebhookConfiguration" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// HTTPS URL to receive webhook POST requests. Must be publicly accessible
        /// </param>
        /// <param name="webhookHeaders">
        /// Custom HTTP headers to include in webhook requests. Use for authentication tokens or custom routing. Example: {'Authorization': 'Bearer xyz'}
        /// </param>
        /// <param name="webhookEvents">
        /// Events that trigger this webhook. Options: 'parse.success' (job completed), 'parse.failure' (job failed), 'parse.partial' (some pages failed). If not specified, webhook fires for all events
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseWebhookConfiguration(
            string? webhookUrl,
            object? webhookHeaders,
            global::System.Collections.Generic.IList<string>? webhookEvents)
        {
            this.WebhookUrl = webhookUrl;
            this.WebhookHeaders = webhookHeaders;
            this.WebhookEvents = webhookEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseWebhookConfiguration" /> class.
        /// </summary>
        public LlamaParseWebhookConfiguration()
        {
        }
    }
}