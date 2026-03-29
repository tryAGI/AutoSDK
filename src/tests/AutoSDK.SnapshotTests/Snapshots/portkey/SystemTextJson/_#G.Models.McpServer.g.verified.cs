//HintName: G.Models.McpServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// MCP Integration ID or slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_integration_id")]
        public string? McpIntegrationId { get; set; }

        /// <summary>
        /// Present for system/service auth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_integration_details")]
        public global::G.McpServerMcpIntegrationDetails? McpIntegrationDetails { get; set; }

        /// <summary>
        /// Present for system/service auth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServer" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="mcpIntegrationId">
        /// MCP Integration ID or slug
        /// </param>
        /// <param name="mcpIntegrationDetails">
        /// Present for system/service auth
        /// </param>
        /// <param name="workspaceId">
        /// Present for system/service auth
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServer(
            global::System.Guid? id,
            string? slug,
            string? name,
            string? status,
            string? description,
            global::System.DateTime? createdAt,
            string? mcpIntegrationId,
            global::G.McpServerMcpIntegrationDetails? mcpIntegrationDetails,
            string? workspaceId)
        {
            this.Id = id;
            this.Slug = slug;
            this.Name = name;
            this.Status = status;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.McpIntegrationId = mcpIntegrationId;
            this.McpIntegrationDetails = mcpIntegrationDetails;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServer" /> class.
        /// </summary>
        public McpServer()
        {
        }
    }
}