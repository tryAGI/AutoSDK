//HintName: G.Models.CreateApiKeyObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyObject
    {
        /// <summary>
        /// Example: Development API Key
        /// </summary>
        /// <example>Development API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: API key for development environment
        /// </summary>
        /// <example>API key for development environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: ws-myworkspace
        /// </summary>
        /// <example>ws-myworkspace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// **Required** when sub-type path parameter is 'user'. Not required when sub-type is 'service'.<br/>
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </summary>
        /// <example>c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.CreateApiKeyObjectRateLimit>? RateLimits { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// Example: [completions.write]
        /// </summary>
        /// <example>[completions.write]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public global::G.CreateApiKeyObjectDefaults? Defaults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_emails")]
        public global::System.Collections.Generic.IList<string>? AlertEmails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObject" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: Development API Key
        /// </param>
        /// <param name="scopes">
        /// Example: [completions.write]
        /// </param>
        /// <param name="description">
        /// Example: API key for development environment
        /// </param>
        /// <param name="workspaceId">
        /// Example: ws-myworkspace
        /// </param>
        /// <param name="userId">
        /// **Required** when sub-type path parameter is 'user'. Not required when sub-type is 'service'.<br/>
        /// Example: c3d4e5f6-a7b8-6c7d-0e1f-2a3b4c5d6e7f
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="defaults"></param>
        /// <param name="alertEmails"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyObject(
            string name,
            global::System.Collections.Generic.IList<string> scopes,
            string? description,
            string? workspaceId,
            global::System.Guid? userId,
            global::System.Collections.Generic.IList<global::G.CreateApiKeyObjectRateLimit>? rateLimits,
            global::G.UsageLimits? usageLimits,
            global::G.CreateApiKeyObjectDefaults? defaults,
            global::System.Collections.Generic.IList<string>? alertEmails,
            global::System.DateTime? expiresAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.WorkspaceId = workspaceId;
            this.UserId = userId;
            this.RateLimits = rateLimits;
            this.UsageLimits = usageLimits;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Defaults = defaults;
            this.AlertEmails = alertEmails;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyObject" /> class.
        /// </summary>
        public CreateApiKeyObject()
        {
        }
    }
}