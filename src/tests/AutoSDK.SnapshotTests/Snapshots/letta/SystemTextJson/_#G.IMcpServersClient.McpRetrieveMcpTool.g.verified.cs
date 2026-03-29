//HintName: G.IMcpServersClient.McpRetrieveMcpTool.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Retrieve Mcp Tool<br/>
        /// Get a specific MCP tool by its ID
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="toolId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> McpRetrieveMcpToolAsync(
            string mcpServerId,
            string toolId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}