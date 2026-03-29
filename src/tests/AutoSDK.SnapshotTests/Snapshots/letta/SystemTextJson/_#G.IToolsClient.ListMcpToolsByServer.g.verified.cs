//HintName: G.IToolsClient.ListMcpToolsByServer.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Mcp Tools By Server<br/>
        /// Get a list of all tools for a specific MCP server
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MCPTool>> ListMcpToolsByServerAsync(
            string mcpServerName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}