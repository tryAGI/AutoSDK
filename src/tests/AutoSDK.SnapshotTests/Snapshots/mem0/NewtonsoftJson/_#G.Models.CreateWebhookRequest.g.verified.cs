//HintName: G.Models.CreateWebhookRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookRequest
    {
        /// <summary>
        /// Name of the webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL endpoint for the webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// List of event types to subscribe to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_types")]
        public global::System.Collections.Generic.IList<global::G.CreateWebhookRequestEventType>? EventTypes { get; set; }

        /// <summary>
        /// Whether the webhook is active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Unique identifier of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// URL endpoint for the webhook.
        /// </param>
        /// <param name="name">
        /// Name of the webhook
        /// </param>
        /// <param name="eventTypes">
        /// List of event types to subscribe to.
        /// </param>
        /// <param name="isActive">
        /// Whether the webhook is active
        /// </param>
        /// <param name="projectId">
        /// Unique identifier of the project.
        /// </param>
        public CreateWebhookRequest(
            string url,
            string? name,
            global::System.Collections.Generic.IList<global::G.CreateWebhookRequestEventType>? eventTypes,
            bool? isActive,
            string? projectId)
        {
            this.Name = name;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EventTypes = eventTypes;
            this.IsActive = isActive;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookRequest" /> class.
        /// </summary>
        public CreateWebhookRequest()
        {
        }
    }
}