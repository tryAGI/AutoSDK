//HintName: G.Models.GetProjectWebhooksResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectWebhooksResponseItem
    {
        /// <summary>
        /// Unique identifier of the webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_id")]
        public string? WebhookId { get; set; }

        /// <summary>
        /// Name of the webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL endpoint for the webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// List of event types the webhook subscribes to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_types")]
        public global::System.Collections.Generic.IList<string>? EventTypes { get; set; }

        /// <summary>
        /// Whether the webhook is active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Name of the project the webhook is associated with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public string? Project { get; set; }

        /// <summary>
        /// Timestamp when the webhook was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the webhook was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectWebhooksResponseItem" /> class.
        /// </summary>
        /// <param name="webhookId">
        /// Unique identifier of the webhook.
        /// </param>
        /// <param name="name">
        /// Name of the webhook
        /// </param>
        /// <param name="url">
        /// URL endpoint for the webhook.
        /// </param>
        /// <param name="eventTypes">
        /// List of event types the webhook subscribes to.
        /// </param>
        /// <param name="isActive">
        /// Whether the webhook is active
        /// </param>
        /// <param name="project">
        /// Name of the project the webhook is associated with
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the webhook was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the webhook was last updated
        /// </param>
        public GetProjectWebhooksResponseItem(
            string? webhookId,
            string? name,
            string? url,
            global::System.Collections.Generic.IList<string>? eventTypes,
            bool? isActive,
            string? project,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.WebhookId = webhookId;
            this.Name = name;
            this.Url = url;
            this.EventTypes = eventTypes;
            this.IsActive = isActive;
            this.Project = project;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectWebhooksResponseItem" /> class.
        /// </summary>
        public GetProjectWebhooksResponseItem()
        {
        }
    }
}