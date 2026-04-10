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
        [global::Newtonsoft.Json.JsonProperty("webhook_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string WebhookUrl { get; set; } = default!;

        /// <summary>
        /// Array of event types to subscribe to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled_events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EnabledEvents { get; set; } = default!;

        /// <summary>
        /// Webhook payload version<br/>
        /// Default Value: V3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PostWebhookSubscriptionsRequestVersionJsonConverter))]
        public global::G.PostWebhookSubscriptionsRequestVersion? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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