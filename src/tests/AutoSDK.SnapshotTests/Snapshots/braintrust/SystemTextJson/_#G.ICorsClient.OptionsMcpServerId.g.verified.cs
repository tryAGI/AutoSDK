//HintName: G.ICorsClient.OptionsMcpServerId.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/mcp_server/{mcp_server_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="mcpServerId">
        /// McpServer id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsMcpServerIdAsync(
            global::System.Guid mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}