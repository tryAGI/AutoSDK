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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New URL endpoint for the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// New list of event types to subscribe to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        public global::System.Collections.Generic.IList<global::G.UpdateWebhookRequestEventType>? EventTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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