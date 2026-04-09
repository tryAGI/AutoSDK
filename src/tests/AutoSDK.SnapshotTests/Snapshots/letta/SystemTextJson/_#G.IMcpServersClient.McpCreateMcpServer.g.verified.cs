//HintName: G.IMcpServersClient.McpCreateMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Create Mcp Server<br/>
        /// Add a new MCP server to the Letta MCP server config
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>> McpCreateMcpServerAsync(

            global::G.CreateMCPServerRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Mcp Server<br/>
        /// Add a new MCP server to the Letta MCP server config
        /// </summary>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="config">
        /// The MCP server configuration (Stdio, SSE, or Streamable HTTP)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>> McpCreateMcpServerAsync(
            string serverName,
            global::G.Config config,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}