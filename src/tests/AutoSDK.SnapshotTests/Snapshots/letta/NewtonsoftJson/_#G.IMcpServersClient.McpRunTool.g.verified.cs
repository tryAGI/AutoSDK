//HintName: G.IMcpServersClient.McpRunTool.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Run Mcp Tool<br/>
        /// Execute a specific MCP tool<br/>
        /// The request body should contain the tool arguments in the ToolExecuteRequest format.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolExecutionResult> McpRunToolAsync(
            string mcpServerId,
            string toolId,

            global::G.LettaSchemasMcpServerToolExecuteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Mcp Tool<br/>
        /// Execute a specific MCP tool<br/>
        /// The request body should contain the tool arguments in the ToolExecuteRequest format.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="toolId"></param>
        /// <param name="args">
        /// Arguments to pass to the tool
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolExecutionResult> McpRunToolAsync(
            string mcpServerId,
            string toolId,
            object? args = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}