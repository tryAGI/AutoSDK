//HintName: G.Models.McpIntegration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        public object? Configurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_workspace_access")]
        public object? GlobalWorkspaceAccess { get; set; }

        /// <summary>
        /// Workspace ID or slug (when workspace-scoped)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.McpIntegrationAuthTypeJsonConverter))]
        public global::G.McpIntegrationAuthType? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.McpIntegrationTransportJsonConverter))]
        public global::G.McpIntegrationTransport? Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.McpIntegrationTypeJsonConverter))]
        public global::G.McpIntegrationType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegration" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="ownerId"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="configurations"></param>
        /// <param name="globalWorkspaceAccess"></param>
        /// <param name="workspaceId">
        /// Workspace ID or slug (when workspace-scoped)
        /// </param>
        /// <param name="slug"></param>
        /// <param name="url"></param>
        /// <param name="authType"></param>
        /// <param name="transport"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpIntegration(
            global::System.Guid? id,
            string? name,
            string? description,
            string? ownerId,
            string? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            object? configurations,
            object? globalWorkspaceAccess,
            string? workspaceId,
            string? slug,
            string? url,
            global::G.McpIntegrationAuthType? authType,
            global::G.McpIntegrationTransport? transport,
            global::G.McpIntegrationType? type)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.OwnerId = ownerId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Configurations = configurations;
            this.GlobalWorkspaceAccess = globalWorkspaceAccess;
            this.WorkspaceId = workspaceId;
            this.Slug = slug;
            this.Url = url;
            this.AuthType = authType;
            this.Transport = transport;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegration" /> class.
        /// </summary>
        public McpIntegration()
        {
        }
    }
}