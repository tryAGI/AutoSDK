//HintName: G.Models.GetAuthSessionInfoResponseProject.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the current active project (null if accessing with org-level credentials)
    /// </summary>
    public sealed partial class GetAuthSessionInfoResponseProject
    {
        /// <summary>
        /// Internal auto-incrementing ID for the project<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AutoId { get; set; }

        /// <summary>
        /// UUID identifier for the project<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Organization UUID that this project belongs to<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440001
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// User-defined name for the project<br/>
        /// Example: Production API
        /// </summary>
        /// <example>Production API</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Email address used for project notifications<br/>
        /// Example: project-123@composio.dev
        /// </summary>
        /// <example>project-123@composio.dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Short, URL-friendly unique identifier for the project<br/>
        /// Example: proj_abc123xyz456
        /// </summary>
        /// <example>proj_abc123xyz456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nano_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NanoId { get; set; }

        /// <summary>
        /// Date and time when the project was created<br/>
        /// Example: 2023-05-16T14:30:00.000Z
        /// </summary>
        /// <example>2023-05-16T14:30:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Date and time when the project was last modified<br/>
        /// Example: 2023-05-18T09:15:30.000Z
        /// </summary>
        /// <example>2023-05-18T09:15:30.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Endpoint URL for trigger webhook notifications<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Endpoint URL for event webhook notifications<br/>
        /// Example: https://example.com/events
        /// </summary>
        /// <example>https://example.com/events</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_webhook_url")]
        public string? EventWebhookUrl { get; set; }

        /// <summary>
        /// Secret used to verify webhook signatures<br/>
        /// Example: whsec_a1b2c3d4e5f6g7h8i9j0
        /// </summary>
        /// <example>whsec_a1b2c3d4e5f6g7h8i9j0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Flag indicating if triggers are enabled for this project<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TriggersEnabled { get; set; }

        /// <summary>
        /// Date and time when the project last subscribed to updates<br/>
        /// Example: 2023-05-17T10:00:00.000Z
        /// </summary>
        /// <example>2023-05-17T10:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_subscribed_at")]
        public string? LastSubscribedAt { get; set; }

        /// <summary>
        /// Flag indicating if the project has been deleted<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Deprecated: Please refer to webhook_version instead. True indicates if the webhook configuration is using the previous new format (V2). False indicates the oldest format (V1)<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_new_webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsNewWebhook { get; set; }

        /// <summary>
        /// Version of the webhook configuration<br/>
        /// Example: V2
        /// </summary>
        /// <example>V2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAuthSessionInfoResponseProjectWebhookVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAuthSessionInfoResponseProjectWebhookVersion WebhookVersion { get; set; }

        /// <summary>
        /// Organization details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAuthSessionInfoResponseProjectOrg Org { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseProject" /> class.
        /// </summary>
        /// <param name="autoId">
        /// Internal auto-incrementing ID for the project<br/>
        /// Example: 12345
        /// </param>
        /// <param name="id">
        /// UUID identifier for the project<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="orgId">
        /// Organization UUID that this project belongs to<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440001
        /// </param>
        /// <param name="name">
        /// User-defined name for the project<br/>
        /// Example: Production API
        /// </param>
        /// <param name="email">
        /// Email address used for project notifications<br/>
        /// Example: project-123@composio.dev
        /// </param>
        /// <param name="nanoId">
        /// Short, URL-friendly unique identifier for the project<br/>
        /// Example: proj_abc123xyz456
        /// </param>
        /// <param name="createdAt">
        /// Date and time when the project was created<br/>
        /// Example: 2023-05-16T14:30:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// Date and time when the project was last modified<br/>
        /// Example: 2023-05-18T09:15:30.000Z
        /// </param>
        /// <param name="triggersEnabled">
        /// Flag indicating if triggers are enabled for this project<br/>
        /// Example: true
        /// </param>
        /// <param name="deleted">
        /// Flag indicating if the project has been deleted<br/>
        /// Example: false
        /// </param>
        /// <param name="isNewWebhook">
        /// Deprecated: Please refer to webhook_version instead. True indicates if the webhook configuration is using the previous new format (V2). False indicates the oldest format (V1)<br/>
        /// Example: true
        /// </param>
        /// <param name="webhookVersion">
        /// Version of the webhook configuration<br/>
        /// Example: V2
        /// </param>
        /// <param name="org">
        /// Organization details
        /// </param>
        /// <param name="webhookUrl">
        /// Endpoint URL for trigger webhook notifications<br/>
        /// Example: https://example.com/webhook
        /// </param>
        /// <param name="eventWebhookUrl">
        /// Endpoint URL for event webhook notifications<br/>
        /// Example: https://example.com/events
        /// </param>
        /// <param name="webhookSecret">
        /// Secret used to verify webhook signatures<br/>
        /// Example: whsec_a1b2c3d4e5f6g7h8i9j0
        /// </param>
        /// <param name="lastSubscribedAt">
        /// Date and time when the project last subscribed to updates<br/>
        /// Example: 2023-05-17T10:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthSessionInfoResponseProject(
            double autoId,
            string id,
            string orgId,
            string name,
            string email,
            string nanoId,
            string createdAt,
            string updatedAt,
            bool triggersEnabled,
            bool deleted,
            bool isNewWebhook,
            global::G.GetAuthSessionInfoResponseProjectWebhookVersion webhookVersion,
            global::G.GetAuthSessionInfoResponseProjectOrg org,
            string? webhookUrl,
            string? eventWebhookUrl,
            string? webhookSecret,
            string? lastSubscribedAt)
        {
            this.AutoId = autoId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.NanoId = nanoId ?? throw new global::System.ArgumentNullException(nameof(nanoId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.WebhookUrl = webhookUrl;
            this.EventWebhookUrl = eventWebhookUrl;
            this.WebhookSecret = webhookSecret;
            this.TriggersEnabled = triggersEnabled;
            this.LastSubscribedAt = lastSubscribedAt;
            this.Deleted = deleted;
            this.IsNewWebhook = isNewWebhook;
            this.WebhookVersion = webhookVersion;
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseProject" /> class.
        /// </summary>
        public GetAuthSessionInfoResponseProject()
        {
        }
    }
}