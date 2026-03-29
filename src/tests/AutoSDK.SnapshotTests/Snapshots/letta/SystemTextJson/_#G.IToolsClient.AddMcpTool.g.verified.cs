//HintName: G.IToolsClient.AddMcpTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Add Mcp Tool<br/>
        /// Register a new MCP tool as a Letta server by MCP server + tool name
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="mcpToolName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> AddMcpToolAsync(
            string mcpServerName,
            string mcpToolName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}