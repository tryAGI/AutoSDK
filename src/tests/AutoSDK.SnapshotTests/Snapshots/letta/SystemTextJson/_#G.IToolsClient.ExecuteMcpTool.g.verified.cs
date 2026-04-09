//HintName: G.IToolsClient.ExecuteMcpTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Execute Mcp Tool<br/>
        /// Execute a specific MCP tool from a configured server.<br/>
        /// Returns the tool execution result.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="toolName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteMcpToolAsync(
            string mcpServerName,
            string toolName,

            global::G.LettaServerRestApiRoutersV1ToolsToolExecuteRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Mcp Tool<br/>
        /// Execute a specific MCP tool from a configured server.<br/>
        /// Returns the tool execution result.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="toolName"></param>
        /// <param name="args">
        /// Arguments to pass to the tool
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteMcpToolAsync(
            string mcpServerName,
            string toolName,
            object? args = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}