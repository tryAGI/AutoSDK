//HintName: G.IMcpServersClient.McpListMcpServers.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// List Mcp Servers<br/>
        /// Get a list of all configured MCP servers
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>>> McpListMcpServersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}