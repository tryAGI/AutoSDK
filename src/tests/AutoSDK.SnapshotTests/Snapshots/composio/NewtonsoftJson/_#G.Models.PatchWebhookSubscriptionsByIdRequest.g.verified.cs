//HintName: G.Models.PatchWebhookSubscriptionsByIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWebhookSubscriptionsByIdRequest
    {
        /// <summary>
        /// HTTPS URL to receive webhook events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Array of event types to subscribe to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_events")]
        public global::System.Collections.Generic.IList<string>? EnabledEvents { get; set; }

        /// <summary>
        /// Webhook payload version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public global::G.PatchWebhookSubscriptionsByIdRequestVersion? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookSubscriptionsByIdRequest" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// HTTPS URL to receive webhook events
        /// </param>
        /// <param name="enabledEvents">
        /// Array of event types to subscribe to
        /// </param>
        /// <param name="version">
        /// Webhook payload version
        /// </param>
        public PatchWebhookSubscriptionsByIdRequest(
            string? webhookUrl,
            global::System.Collections.Generic.IList<string>? enabledEvents,
            global::G.PatchWebhookSubscriptionsByIdRequestVersion? version)
        {
            this.WebhookUrl = webhookUrl;
            this.EnabledEvents = enabledEvents;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookSubscriptionsByIdRequest" /> class.
        /// </summary>
        public PatchWebhookSubscriptionsByIdRequest()
        {
        }
    }
}