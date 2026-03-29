//HintName: G.IToolsClient.AddMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Add Mcp Server To Config<br/>
        /// Add a new MCP server to the Letta MCP server config
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>>> AddMcpServerAsync(

            global::G.AnyOf<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Mcp Server To Config<br/>
        /// Add a new MCP server to the Letta MCP server config
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>>> AddMcpServerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}