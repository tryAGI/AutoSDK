//HintName: G.IMcpServersClient.McpRefreshMcpServerTools.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Refresh Mcp Server Tools<br/>
        /// Refresh tools for an MCP server by:<br/>
        /// 1. Fetching current tools from the MCP server<br/>
        /// 2. Deleting tools that no longer exist on the server<br/>
        /// 3. Updating schemas for existing tools<br/>
        /// 4. Adding new tools from the server<br/>
        /// Returns a summary of changes made.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpRefreshMcpServerToolsAsync(
            string mcpServerId,
            string? agentId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}