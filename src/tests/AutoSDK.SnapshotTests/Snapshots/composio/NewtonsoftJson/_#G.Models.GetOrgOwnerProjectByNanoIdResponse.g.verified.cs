//HintName: G.Models.GetOrgOwnerProjectByNanoIdResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrgOwnerProjectByNanoIdResponse
    {
        /// <summary>
        /// Unique identifier for the project<br/>
        /// Example: proj_abc123xyz456
        /// </summary>
        /// <example>proj_abc123xyz456</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Identifier of the organization that owns this project<br/>
        /// Example: org_abc123xyz456
        /// </summary>
        /// <example>org_abc123xyz456</example>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// Name of the project<br/>
        /// Example: My Awesome Project
        /// </summary>
        /// <example>My Awesome Project</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Email address associated with the project<br/>
        /// Example: project-123@composio.dev
        /// </summary>
        /// <example>project-123@composio.dev</example>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// ISO timestamp when the project was created<br/>
        /// Example: 2023-05-16T14:30:00.000Z
        /// </summary>
        /// <example>2023-05-16T14:30:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// ISO timestamp when the project was last updated<br/>
        /// Example: 2023-05-18T09:15:30.000Z
        /// </summary>
        /// <example>2023-05-18T09:15:30.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// DEPRECATED: Use GET /api/v3/webhook_subscriptions instead. Legacy project-level webhook URL.<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// DEPRECATED: No longer used.<br/>
        /// Example: https://example.com/events
        /// </summary>
        /// <example>https://example.com/events</example>
        [global::Newtonsoft.Json.JsonProperty("event_webhook_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EventWebhookUrl { get; set; }

        /// <summary>
        /// DEPRECATED: Use GET /api/v3/webhook_subscriptions instead. Legacy project-level webhook secret.<br/>
        /// Example: whsec_abcdef123456789
        /// </summary>
        /// <example>whsec_abcdef123456789</example>
        [global::Newtonsoft.Json.JsonProperty("webhook_secret")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Whether triggers are enabled for this project<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("triggers_enabled")]
        public bool? TriggersEnabled { get; set; }

        /// <summary>
        /// ISO timestamp when the project last subscribed to updates<br/>
        /// Example: 2023-05-17T10:00:00.000Z
        /// </summary>
        /// <example>2023-05-17T10:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("last_subscribed_at")]
        public global::System.DateTime? LastSubscribedAt { get; set; }

        /// <summary>
        /// Deprecated: Please refer to webhook_version instead. True indicates if the webhook configuration is using the previous new format (V2). False indicates the oldest format (V1)<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_new_webhook")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? IsNewWebhook { get; set; }

        /// <summary>
        /// Payload format version for Pusher real-time events only. For webhook configuration, use GET /api/v3/webhook_subscriptions.<br/>
        /// Example: V2
        /// </summary>
        /// <example>V2</example>
        [global::Newtonsoft.Json.JsonProperty("webhook_version", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetOrgOwnerProjectByNanoIdResponseWebhookVersion WebhookVersion { get; set; } = default!;

        /// <summary>
        /// Whether this project has been soft-deleted<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Array of API keys for the project, including their properties
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_keys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetOrgOwnerProjectByNanoIdResponseApiKey> ApiKeys { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgOwnerProjectByNanoIdResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the project<br/>
        /// Example: proj_abc123xyz456
        /// </param>
        /// <param name="orgId">
        /// Identifier of the organization that owns this project<br/>
        /// Example: org_abc123xyz456
        /// </param>
        /// <param name="name">
        /// Name of the project<br/>
        /// Example: My Awesome Project
        /// </param>
        /// <param name="email">
        /// Email address associated with the project<br/>
        /// Example: project-123@composio.dev
        /// </param>
        /// <param name="createdAt">
        /// ISO timestamp when the project was created<br/>
        /// Example: 2023-05-16T14:30:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// ISO timestamp when the project was last updated<br/>
        /// Example: 2023-05-18T09:15:30.000Z
        /// </param>
        /// <param name="webhookVersion">
        /// Payload format version for Pusher real-time events only. For webhook configuration, use GET /api/v3/webhook_subscriptions.<br/>
        /// Example: V2
        /// </param>
        /// <param name="deleted">
        /// Whether this project has been soft-deleted<br/>
        /// Example: false
        /// </param>
        /// <param name="apiKeys">
        /// Array of API keys for the project, including their properties
        /// </param>
        /// <param name="triggersEnabled">
        /// Whether triggers are enabled for this project<br/>
        /// Example: true
        /// </param>
        /// <param name="lastSubscribedAt">
        /// ISO timestamp when the project last subscribed to updates<br/>
        /// Example: 2023-05-17T10:00:00.000Z
        /// </param>
        public GetOrgOwnerProjectByNanoIdResponse(
            string id,
            string orgId,
            string name,
            string email,
            string createdAt,
            string updatedAt,
            global::G.GetOrgOwnerProjectByNanoIdResponseWebhookVersion webhookVersion,
            bool deleted,
            global::System.Collections.Generic.IList<global::G.GetOrgOwnerProjectByNanoIdResponseApiKey> apiKeys,
            bool? triggersEnabled,
            global::System.DateTime? lastSubscribedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.TriggersEnabled = triggersEnabled;
            this.LastSubscribedAt = lastSubscribedAt;
            this.WebhookVersion = webhookVersion;
            this.Deleted = deleted;
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgOwnerProjectByNanoIdResponse" /> class.
        /// </summary>
        public GetOrgOwnerProjectByNanoIdResponse()
        {
        }
    }
}