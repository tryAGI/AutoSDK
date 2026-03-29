//HintName: G.IMcpServersClient.McpDeleteMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Delete Mcp Server<br/>
        /// Delete an MCP server by its ID
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task McpDeleteMcpServerAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}