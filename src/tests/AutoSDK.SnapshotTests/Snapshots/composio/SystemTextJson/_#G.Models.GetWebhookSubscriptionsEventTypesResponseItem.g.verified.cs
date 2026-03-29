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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventType { get; set; }

        /// <summary>
        /// Human-readable description of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Webhook versions that support this event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersion> SupportedVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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