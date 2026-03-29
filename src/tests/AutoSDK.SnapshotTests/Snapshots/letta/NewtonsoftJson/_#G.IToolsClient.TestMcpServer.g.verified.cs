//HintName: G.IToolsClient.TestMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Test Mcp Server<br/>
        /// Test connection to an MCP server without adding it.<br/>
        /// Returns the list of available tools if successful.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestMcpServerAsync(

            global::G.AnyOf<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Mcp Server<br/>
        /// Test connection to an MCP server without adding it.<br/>
        /// Returns the list of available tools if successful.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TestMcpServerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}