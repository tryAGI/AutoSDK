//HintName: G.Models.CreateMcpServer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create an MCP Server (workspace instance of an MCP Integration).
    /// </summary>
    public sealed partial class CreateMcpServer
    {
        /// <summary>
        /// Workspace ID or slug (optional; required when using org admin API key)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Display name of the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// MCP Integration ID (UUID) or slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_integration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpIntegrationId { get; set; }

        /// <summary>
        /// Optional slug; must be unique within organisation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpServer" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the MCP server
        /// </param>
        /// <param name="mcpIntegrationId">
        /// MCP Integration ID (UUID) or slug
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID or slug (optional; required when using org admin API key)
        /// </param>
        /// <param name="description"></param>
        /// <param name="slug">
        /// Optional slug; must be unique within organisation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMcpServer(
            string name,
            string mcpIntegrationId,
            global::System.Guid? workspaceId,
            string? description,
            string? slug)
        {
            this.WorkspaceId = workspaceId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.McpIntegrationId = mcpIntegrationId ?? throw new global::System.ArgumentNullException(nameof(mcpIntegrationId));
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMcpServer" /> class.
        /// </summary>
        public CreateMcpServer()
        {
        }
    }
}