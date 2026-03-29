//HintName: G.IMcpServersClient.GetMcpServerId.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Get mcp_server<br/>
        /// Get a mcp_server object by its id
        /// </summary>
        /// <param name="mcpServerId">
        /// McpServer id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MCPServer> GetMcpServerIdAsync(
            global::System.Guid mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}