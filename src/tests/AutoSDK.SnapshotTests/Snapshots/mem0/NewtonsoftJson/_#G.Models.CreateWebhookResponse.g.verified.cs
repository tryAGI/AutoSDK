//HintName: G.Models.CreateWebhookResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_id")]
        public string? WebhookId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_types")]
        public global::System.Collections.Generic.IList<string>? EventTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public string? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookResponse" /> class.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="eventTypes"></param>
        /// <param name="isActive"></param>
        /// <param name="project"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public CreateWebhookResponse(
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
        /// Initializes a new instance of the <see cref="CreateWebhookResponse" /> class.
        /// </summary>
        public CreateWebhookResponse()
        {
        }
    }
}