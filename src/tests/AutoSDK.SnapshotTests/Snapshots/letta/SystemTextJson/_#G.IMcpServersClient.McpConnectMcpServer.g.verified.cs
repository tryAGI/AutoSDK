//HintName: G.IMcpServersClient.McpConnectMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Connect Mcp Server<br/>
        /// Connect to an MCP server with support for OAuth via SSE.<br/>
        /// Returns a stream of events handling authorization state and exchange if OAuth is required.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpConnectMcpServerAsync(
            string mcpServerId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}