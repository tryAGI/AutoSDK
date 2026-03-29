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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL endpoint for the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// List of event types to subscribe to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        public global::System.Collections.Generic.IList<global::G.CreateWebhookRequestEventType>? EventTypes { get; set; }

        /// <summary>
        /// Whether the webhook is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Unique identifier of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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