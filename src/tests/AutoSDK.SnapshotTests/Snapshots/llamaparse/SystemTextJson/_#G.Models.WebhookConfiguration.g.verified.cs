//HintName: G.Models.WebhookConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a single outbound webhook endpoint.
    /// </summary>
    public sealed partial class WebhookConfiguration
    {
        /// <summary>
        /// URL to receive webhook POST notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Custom HTTP headers sent with each webhook request (e.g. auth tokens)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? WebhookHeaders { get; set; }

        /// <summary>
        /// Events to subscribe to (e.g. 'parse.success', 'extract.error'). If null, all events are delivered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events")]
        public global::System.Collections.Generic.IList<global::G.WebhookConfigurationWebhookEventsVariant1Item>? WebhookEvents { get; set; }

        /// <summary>
        /// Response format sent to the webhook: 'string' (default) or 'json'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_output_format")]
        public string? WebhookOutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfiguration" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// URL to receive webhook POST notifications
        /// </param>
        /// <param name="webhookHeaders">
        /// Custom HTTP headers sent with each webhook request (e.g. auth tokens)
        /// </param>
        /// <param name="webhookEvents">
        /// Events to subscribe to (e.g. 'parse.success', 'extract.error'). If null, all events are delivered.
        /// </param>
        /// <param name="webhookOutputFormat">
        /// Response format sent to the webhook: 'string' (default) or 'json'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookConfiguration(
            string? webhookUrl,
            global::System.Collections.Generic.Dictionary<string, string>? webhookHeaders,
            global::System.Collections.Generic.IList<global::G.WebhookConfigurationWebhookEventsVariant1Item>? webhookEvents,
            string? webhookOutputFormat)
        {
            this.WebhookUrl = webhookUrl;
            this.WebhookHeaders = webhookHeaders;
            this.WebhookEvents = webhookEvents;
            this.WebhookOutputFormat = webhookOutputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookConfiguration" /> class.
        /// </summary>
        public WebhookConfiguration()
        {
        }
    }
}