//HintName: G.IMcpServersClient.McpServersCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Create MCP Server<br/>
        /// Create a new MCP Server (workspace instance of an MCP Integration). Requires workspace_id or x-portkey-api-key header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerCreateResponse> McpServersCreateAsync(

            global::G.CreateMcpServer request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create MCP Server<br/>
        /// Create a new MCP Server (workspace instance of an MCP Integration). Requires workspace_id or x-portkey-api-key header.
        /// </summary>
        /// <param name="workspaceId">
        /// Workspace ID or slug (optional; required when using org admin API key)
        /// </param>
        /// <param name="name">
        /// Display name of the MCP server
        /// </param>
        /// <param name="description"></param>
        /// <param name="mcpIntegrationId">
        /// MCP Integration ID (UUID) or slug
        /// </param>
        /// <param name="slug">
        /// Optional slug; must be unique within organisation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerCreateResponse> McpServersCreateAsync(
            string name,
            string mcpIntegrationId,
            global::System.Guid? workspaceId = default,
            string? description = default,
            string? slug = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}