//HintName: G.IMcpServersClient.McpServersUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Update MCP Server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpServersUpdateAsync(
            string mcpServerId,

            global::G.UpdateMcpServer request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update MCP Server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> McpServersUpdateAsync(
            string mcpServerId,
            string? name = default,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}