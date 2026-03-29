//HintName: G.Models.GetOrgOwnerProjectListResponseDataItem.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrgOwnerProjectListResponseDataItem
    {
        /// <summary>
        /// Unique identifier for the project<br/>
        /// Example: proj_abc123xyz456
        /// </summary>
        /// <example>proj_abc123xyz456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Identifier of the organization that owns this project<br/>
        /// Example: org_abc123xyz456
        /// </summary>
        /// <example>org_abc123xyz456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Name of the project<br/>
        /// Example: My Awesome Project
        /// </summary>
        /// <example>My Awesome Project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Email address associated with the project<br/>
        /// Example: project-123@composio.dev
        /// </summary>
        /// <example>project-123@composio.dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// ISO timestamp when the project was created<br/>
        /// Example: 2023-05-16T14:30:00.000Z
        /// </summary>
        /// <example>2023-05-16T14:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ISO timestamp when the project was last updated<br/>
        /// Example: 2023-05-18T09:15:30.000Z
        /// </summary>
        /// <example>2023-05-18T09:15:30.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// DEPRECATED: Use GET /api/v3/webhook_subscriptions instead. Legacy project-level webhook URL.<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// DEPRECATED: No longer used.<br/>
        /// Example: https://example.com/events
        /// </summary>
        /// <example>https://example.com/events</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_webhook_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EventWebhookUrl { get; set; }

        /// <summary>
        /// DEPRECATED: Use GET /api/v3/webhook_subscriptions instead. Legacy project-level webhook secret.<br/>
        /// Example: whsec_abcdef123456789
        /// </summary>
        /// <example>whsec_abcdef123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Whether triggers are enabled for this project<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers_enabled")]
        public bool? TriggersEnabled { get; set; }

        /// <summary>
        /// ISO timestamp when the project last subscribed to updates<br/>
        /// Example: 2023-05-17T10:00:00.000Z
        /// </summary>
        /// <example>2023-05-17T10:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_subscribed_at")]
        public global::System.DateTime? LastSubscribedAt { get; set; }

        /// <summary>
        /// Deprecated: Please refer to webhook_version instead. True indicates if the webhook configuration is using the previous new format (V2). False indicates the oldest format (V1)<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_new_webhook")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? IsNewWebhook { get; set; }

        /// <summary>
        /// Payload format version for Pusher real-time events only. For webhook configuration, use GET /api/v3/webhook_subscriptions.<br/>
        /// Example: V2
        /// </summary>
        /// <example>V2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetOrgOwnerProjectListResponseDataItemWebhookVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersion WebhookVersion { get; set; }

        /// <summary>
        /// Whether this project has been soft-deleted<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgOwnerProjectListResponseDataItem" /> class.
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
        /// <param name="triggersEnabled">
        /// Whether triggers are enabled for this project<br/>
        /// Example: true
        /// </param>
        /// <param name="lastSubscribedAt">
        /// ISO timestamp when the project last subscribed to updates<br/>
        /// Example: 2023-05-17T10:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrgOwnerProjectListResponseDataItem(
            string id,
            string orgId,
            string name,
            string email,
            string createdAt,
            string updatedAt,
            global::G.GetOrgOwnerProjectListResponseDataItemWebhookVersion webhookVersion,
            bool deleted,
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgOwnerProjectListResponseDataItem" /> class.
        /// </summary>
        public GetOrgOwnerProjectListResponseDataItem()
        {
        }
    }
}