//HintName: G.IMcpServersClient.McpServersDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Delete MCP Server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpServersDeleteAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}