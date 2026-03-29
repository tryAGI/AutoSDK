//HintName: G.IToolsClient.ConnectMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Connect Mcp Server<br/>
        /// Connect to an MCP server with support for OAuth via SSE.<br/>
        /// Returns a stream of events handling authorization state and exchange if OAuth is required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConnectMcpServerAsync(

            global::G.AnyOf<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect Mcp Server<br/>
        /// Connect to an MCP server with support for OAuth via SSE.<br/>
        /// Returns a stream of events handling authorization state and exchange if OAuth is required.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConnectMcpServerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}