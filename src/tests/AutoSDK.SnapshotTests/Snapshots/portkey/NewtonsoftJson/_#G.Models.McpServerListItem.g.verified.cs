//HintName: G.Models.McpServerListItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public string? OrganisationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_integration_id")]
        public string? McpIntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_integration_slug")]
        public string? McpIntegrationSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_integration_url")]
        public string? McpIntegrationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_name")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_slug")]
        public string? WorkspaceSlug { get; set; }

        /// <summary>
        /// Gateway URL for this MCP server (e.g. {gateway_base}/{slug}/mcp)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerListItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organisationId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="ownerId"></param>
        /// <param name="slug"></param>
        /// <param name="workspaceId"></param>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="mcpIntegrationSlug"></param>
        /// <param name="mcpIntegrationUrl"></param>
        /// <param name="authType"></param>
        /// <param name="workspaceName"></param>
        /// <param name="workspaceSlug"></param>
        /// <param name="url">
        /// Gateway URL for this MCP server (e.g. {gateway_base}/{slug}/mcp)
        /// </param>
        public McpServerListItem(
            global::System.Guid? id,
            string? organisationId,
            string? name,
            string? description,
            string? status,
            global::System.DateTime? createdAt,
            string? ownerId,
            string? slug,
            string? workspaceId,
            string? mcpIntegrationId,
            string? mcpIntegrationSlug,
            string? mcpIntegrationUrl,
            string? authType,
            string? workspaceName,
            string? workspaceSlug,
            string? url)
        {
            this.Id = id;
            this.OrganisationId = organisationId;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.OwnerId = ownerId;
            this.Slug = slug;
            this.WorkspaceId = workspaceId;
            this.McpIntegrationId = mcpIntegrationId;
            this.McpIntegrationSlug = mcpIntegrationSlug;
            this.McpIntegrationUrl = mcpIntegrationUrl;
            this.AuthType = authType;
            this.WorkspaceName = workspaceName;
            this.WorkspaceSlug = workspaceSlug;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerListItem" /> class.
        /// </summary>
        public McpServerListItem()
        {
        }
    }
}