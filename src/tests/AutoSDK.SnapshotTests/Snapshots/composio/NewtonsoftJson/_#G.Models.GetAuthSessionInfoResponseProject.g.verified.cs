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
        [global::Newtonsoft.Json.JsonProperty("auto_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double AutoId { get; set; } = default!;

        /// <summary>
        /// UUID identifier for the project<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Organization UUID that this project belongs to<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440001
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440001</example>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// User-defined name for the project<br/>
        /// Example: Production API
        /// </summary>
        /// <example>Production API</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Email address used for project notifications<br/>
        /// Example: project-123@composio.dev
        /// </summary>
        /// <example>project-123@composio.dev</example>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Short, URL-friendly unique identifier for the project<br/>
        /// Example: proj_abc123xyz456
        /// </summary>
        /// <example>proj_abc123xyz456</example>
        [global::Newtonsoft.Json.JsonProperty("nano_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NanoId { get; set; } = default!;

        /// <summary>
        /// Date and time when the project was created<br/>
        /// Example: 2023-05-16T14:30:00.000Z
        /// </summary>
        /// <example>2023-05-16T14:30:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Date and time when the project was last modified<br/>
        /// Example: 2023-05-18T09:15:30.000Z
        /// </summary>
        /// <example>2023-05-18T09:15:30.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Endpoint URL for trigger webhook notifications<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Endpoint URL for event webhook notifications<br/>
        /// Example: https://example.com/events
        /// </summary>
        /// <example>https://example.com/events</example>
        [global::Newtonsoft.Json.JsonProperty("event_webhook_url")]
        public string? EventWebhookUrl { get; set; }

        /// <summary>
        /// Secret used to verify webhook signatures<br/>
        /// Example: whsec_a1b2c3d4e5f6g7h8i9j0
        /// </summary>
        /// <example>whsec_a1b2c3d4e5f6g7h8i9j0</example>
        [global::Newtonsoft.Json.JsonProperty("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Flag indicating if triggers are enabled for this project<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("triggers_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool TriggersEnabled { get; set; } = default!;

        /// <summary>
        /// Date and time when the project last subscribed to updates<br/>
        /// Example: 2023-05-17T10:00:00.000Z
        /// </summary>
        /// <example>2023-05-17T10:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("last_subscribed_at")]
        public string? LastSubscribedAt { get; set; }

        /// <summary>
        /// Flag indicating if the project has been deleted<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Deprecated: Please refer to webhook_version instead. True indicates if the webhook configuration is using the previous new format (V2). False indicates the oldest format (V1)<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_new_webhook", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsNewWebhook { get; set; } = default!;

        /// <summary>
        /// Version of the webhook configuration<br/>
        /// Example: V2
        /// </summary>
        /// <example>V2</example>
        [global::Newtonsoft.Json.JsonProperty("webhook_version", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAuthSessionInfoResponseProjectWebhookVersion WebhookVersion { get; set; } = default!;

        /// <summary>
        /// Organization details
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAuthSessionInfoResponseProjectOrg Org { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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