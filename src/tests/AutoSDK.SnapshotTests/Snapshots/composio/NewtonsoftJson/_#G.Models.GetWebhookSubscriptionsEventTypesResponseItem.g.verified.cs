//HintName: G.Models.GetWebhookSubscriptionsEventTypesResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWebhookSubscriptionsEventTypesResponseItem
    {
        /// <summary>
        /// Event type identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventType { get; set; } = default!;

        /// <summary>
        /// Human-readable description of the event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Webhook versions that support this event
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported_versions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion> SupportedVersions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookSubscriptionsEventTypesResponseItem" /> class.
        /// </summary>
        /// <param name="eventType">
        /// Event type identifier
        /// </param>
        /// <param name="description">
        /// Human-readable description of the event
        /// </param>
        /// <param name="supportedVersions">
        /// Webhook versions that support this event
        /// </param>
        public GetWebhookSubscriptionsEventTypesResponseItem(
            string eventType,
            string description,
            global::System.Collections.Generic.IList<global::G.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion> supportedVersions)
        {
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.SupportedVersions = supportedVersions ?? throw new global::System.ArgumentNullException(nameof(supportedVersions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookSubscriptionsEventTypesResponseItem" /> class.
        /// </summary>
        public GetWebhookSubscriptionsEventTypesResponseItem()
        {
        }
    }
}