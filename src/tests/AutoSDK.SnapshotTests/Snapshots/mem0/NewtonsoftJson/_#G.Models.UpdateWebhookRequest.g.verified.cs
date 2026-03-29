//HintName: G.Models.UpdateWebhookRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWebhookRequest
    {
        /// <summary>
        /// New name for the webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New URL endpoint for the webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// New list of event types to subscribe to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_types")]
        public global::System.Collections.Generic.IList<global::G.UpdateWebhookRequestEventType>? EventTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the webhook
        /// </param>
        /// <param name="url">
        /// New URL endpoint for the webhook
        /// </param>
        /// <param name="eventTypes">
        /// New list of event types to subscribe to
        /// </param>
        public UpdateWebhookRequest(
            string? name,
            string? url,
            global::System.Collections.Generic.IList<global::G.UpdateWebhookRequestEventType>? eventTypes)
        {
            this.Name = name;
            this.Url = url;
            this.EventTypes = eventTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookRequest" /> class.
        /// </summary>
        public UpdateWebhookRequest()
        {
        }
    }
}