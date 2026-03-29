//HintName: G.IMcpServersClient.McpRetrieveMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Retrieve Mcp Server<br/>
        /// Get a specific MCP server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>> McpRetrieveMcpServerAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}