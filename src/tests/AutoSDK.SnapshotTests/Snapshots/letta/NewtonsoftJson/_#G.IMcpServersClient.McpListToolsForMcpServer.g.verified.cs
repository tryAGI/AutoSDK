//HintName: G.IMcpServersClient.McpListToolsForMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// List Tools For Mcp Server<br/>
        /// Get a list of all tools for a specific MCP server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tool>> McpListToolsForMcpServerAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}