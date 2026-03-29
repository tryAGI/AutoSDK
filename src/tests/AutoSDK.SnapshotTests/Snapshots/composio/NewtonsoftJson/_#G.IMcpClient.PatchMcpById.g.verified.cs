//HintName: G.IMcpClient.PatchMcpById.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Update MCP server configuration<br/>
        /// Updates the configuration of an existing Model Control Protocol (MCP) server. You can modify the server name, associated applications, and enabled tools. Only the fields included in the request will be updated.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the MCP server to retrieve, update, or delete<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchMcpByIdResponse> PatchMcpByIdAsync(
            string id,

            global::G.PatchMcpByIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update MCP server configuration<br/>
        /// Updates the configuration of an existing Model Control Protocol (MCP) server. You can modify the server name, associated applications, and enabled tools. Only the fields included in the request will be updated.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the MCP server to retrieve, update, or delete<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="name">
        /// Human-readable name to identify this MCP server instance (4-30 characters, alphanumeric, spaces, and hyphens only)<br/>
        /// Example: Production GitHub Integration
        /// </param>
        /// <param name="toolkits">
        /// List of toolkit slugs this server should be configured to work with.<br/>
        /// Example: [gmail, notion]
        /// </param>
        /// <param name="allowedTools">
        /// List of action identifiers that should be enabled for this server<br/>
        /// Example: [GMAIL_ADD_LABEL_TO_EMAIL]
        /// </param>
        /// <param name="managedAuthViaComposio">
        /// Whether the MCP server is managed by Composio<br/>
        /// Example: true
        /// </param>
        /// <param name="authConfigIds">
        /// List of auth config IDs to use for this MCP server.<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PatchMcpByIdResponse> PatchMcpByIdAsync(
            string id,
            string? name = default,
            global::System.Collections.Generic.IList<string>? toolkits = default,
            global::System.Collections.Generic.IList<string>? allowedTools = default,
            bool? managedAuthViaComposio = default,
            global::System.Collections.Generic.IList<string>? authConfigIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}