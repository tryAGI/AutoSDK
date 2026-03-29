//HintName: G.Models.PostMcpServersCustomResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for a successfully created custom MCP server with multiple applications
    /// </summary>
    public sealed partial class PostMcpServersCustomResponse
    {
        /// <summary>
        /// Unique identifier for the newly created custom MCP server<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name of the custom MCP server<br/>
        /// Example: Multi-App Integration Server
        /// </summary>
        /// <example>Multi-App Integration Server</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID references to the auth configurations used by this server<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </summary>
        /// <example>[auth_cfg_abc123def456, auth_cfg_xyz789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AuthConfigIds { get; set; }

        /// <summary>
        /// List of tool identifiers that are enabled for this server<br/>
        /// Example: [github-issues, jira-tickets, slack-messages, custom-api-tool]
        /// </summary>
        /// <example>[github-issues, jira-tickets, slack-messages, custom-api-tool]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedTools { get; set; }

        /// <summary>
        /// URL endpoint for establishing connection to this MCP server<br/>
        /// Example: https://backend.composio.dev/v3/mcp/550e8410-e29b-41d4-a716-446655440000?user_id=john
        /// </summary>
        /// <example>https://backend.composio.dev/v3/mcp/550e8410-e29b-41d4-a716-446655440000?user_id=john</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpUrl { get; set; }

        /// <summary>
        /// Set of command line instructions for connecting various clients to this MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostMcpServersCustomResponseCommands Commands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersCustomResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the newly created custom MCP server<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="name">
        /// Human-readable name of the custom MCP server<br/>
        /// Example: Multi-App Integration Server
        /// </param>
        /// <param name="authConfigIds">
        /// ID references to the auth configurations used by this server<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </param>
        /// <param name="allowedTools">
        /// List of tool identifiers that are enabled for this server<br/>
        /// Example: [github-issues, jira-tickets, slack-messages, custom-api-tool]
        /// </param>
        /// <param name="mcpUrl">
        /// URL endpoint for establishing connection to this MCP server<br/>
        /// Example: https://backend.composio.dev/v3/mcp/550e8410-e29b-41d4-a716-446655440000?user_id=john
        /// </param>
        /// <param name="commands">
        /// Set of command line instructions for connecting various clients to this MCP server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostMcpServersCustomResponse(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> authConfigIds,
            global::System.Collections.Generic.IList<string> allowedTools,
            string mcpUrl,
            global::G.PostMcpServersCustomResponseCommands commands)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthConfigIds = authConfigIds ?? throw new global::System.ArgumentNullException(nameof(authConfigIds));
            this.AllowedTools = allowedTools ?? throw new global::System.ArgumentNullException(nameof(allowedTools));
            this.McpUrl = mcpUrl ?? throw new global::System.ArgumentNullException(nameof(mcpUrl));
            this.Commands = commands ?? throw new global::System.ArgumentNullException(nameof(commands));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersCustomResponse" /> class.
        /// </summary>
        public PostMcpServersCustomResponse()
        {
        }
    }
}