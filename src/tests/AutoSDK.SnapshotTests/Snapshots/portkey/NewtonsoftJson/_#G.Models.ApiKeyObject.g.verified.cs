//HintName: G.Models.ApiKeyObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeyObject
    {
        /// <summary>
        /// Example: f47ac10b-58cc-4372-a567-0e02b2c3d479
        /// </summary>
        /// <example>f47ac10b-58cc-4372-a567-0e02b2c3d479</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Example: Xk*******S4
        /// </summary>
        /// <example>Xk*******S4</example>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Example: Development API Key
        /// </summary>
        /// <example>Development API Key</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: API key for development environment
        /// </summary>
        /// <example>API key for development environment</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: organisation-service
        /// </summary>
        /// <example>organisation-service</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiKeyObjectTypeJsonConverter))]
        public global::G.ApiKeyObjectType? Type { get; set; }

        /// <summary>
        /// Example: a1b2c3d4-e5f6-4a5b-8c7d-9e0f1a2b3c4d
        /// </summary>
        /// <example>a1b2c3d4-e5f6-4a5b-8c7d-9e0f1a2b3c4d</example>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// Example: ws-myworkspace
        /// </summary>
        /// <example>ws-myworkspace</example>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </summary>
        /// <example>c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f</example>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiKeyObjectStatusJsonConverter))]
        public global::G.ApiKeyObjectStatus? Status { get; set; }

        /// <summary>
        /// Example: 2023-09-15T10:30:00Z
        /// </summary>
        /// <example>2023-09-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example: 2023-09-15T10:30:00Z
        /// </summary>
        /// <example>2023-09-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Example: ui
        /// </summary>
        /// <example>ui</example>
        [global::Newtonsoft.Json.JsonProperty("creation_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiKeyObjectCreationModeJsonConverter))]
        public global::G.ApiKeyObjectCreationMode? CreationMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.ApiKeyObjectRateLimit>? RateLimits { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("reset_usage")]
        public double? ResetUsage { get; set; }

        /// <summary>
        /// Example: [completions.write]
        /// </summary>
        /// <example>[completions.write]</example>
        [global::Newtonsoft.Json.JsonProperty("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaults")]
        public global::G.ApiKeyObjectDefaults? Defaults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_emails")]
        public global::System.Collections.Generic.IList<string>? AlertEmails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Example: api-key
        /// </summary>
        /// <example>api-key</example>
        [global::Newtonsoft.Json.JsonProperty("object")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiKeyObjectObjectJsonConverter))]
        public global::G.ApiKeyObjectObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: f47ac10b-58cc-4372-a567-0e02b2c3d479
        /// </param>
        /// <param name="key">
        /// Example: Xk*******S4
        /// </param>
        /// <param name="name">
        /// Example: Development API Key
        /// </param>
        /// <param name="description">
        /// Example: API key for development environment
        /// </param>
        /// <param name="type">
        /// Example: organisation-service
        /// </param>
        /// <param name="organisationId">
        /// Example: a1b2c3d4-e5f6-4a5b-8c7d-9e0f1a2b3c4d
        /// </param>
        /// <param name="workspaceId">
        /// Example: ws-myworkspace
        /// </param>
        /// <param name="userId">
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </param>
        /// <param name="status">
        /// Example: active
        /// </param>
        /// <param name="createdAt">
        /// Example: 2023-09-15T10:30:00Z
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Example: 2023-09-15T10:30:00Z
        /// </param>
        /// <param name="creationMode">
        /// Example: ui
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="resetUsage">
        /// Example: 0
        /// </param>
        /// <param name="scopes">
        /// Example: [completions.write]
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="alertEmails"></param>
        /// <param name="expiresAt"></param>
        /// <param name="object">
        /// Example: api-key
        /// </param>
        public ApiKeyObject(
            global::System.Guid? id,
            string? key,
            string? name,
            string? description,
            global::G.ApiKeyObjectType? type,
            global::System.Guid? organisationId,
            string? workspaceId,
            global::System.Guid? userId,
            global::G.ApiKeyObjectStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            global::G.ApiKeyObjectCreationMode? creationMode,
            global::System.Collections.Generic.IList<global::G.ApiKeyObjectRateLimit>? rateLimits,
            global::G.UsageLimits? usageLimits,
            double? resetUsage,
            global::System.Collections.Generic.IList<string>? scopes,
            global::G.ApiKeyObjectDefaults? defaults,
            global::System.Collections.Generic.IList<string>? alertEmails,
            global::System.DateTime? expiresAt,
            global::G.ApiKeyObjectObject? @object)
        {
            this.Id = id;
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.OrganisationId = organisationId;
            this.WorkspaceId = workspaceId;
            this.UserId = userId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CreationMode = creationMode;
            this.RateLimits = rateLimits;
            this.UsageLimits = usageLimits;
            this.ResetUsage = resetUsage;
            this.Scopes = scopes;
            this.Defaults = defaults;
            this.AlertEmails = alertEmails;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyObject" /> class.
        /// </summary>
        public ApiKeyObject()
        {
        }
    }
}