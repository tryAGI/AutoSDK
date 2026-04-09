//HintName: G.IMcpServersClient.McpUpdateMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Update Mcp Server<br/>
        /// Update an existing MCP server configuration
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>> McpUpdateMcpServerAsync(
            string mcpServerId,

            global::G.UpdateMCPServerRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Server<br/>
        /// Update an existing MCP server configuration
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="config">
        /// The MCP server configuration updates (Stdio, SSE, or Streamable HTTP)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>> McpUpdateMcpServerAsync(
            string mcpServerId,
            global::G.Config4 config,
            string? serverName = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}