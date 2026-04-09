//HintName: G.IMcpServersCapabilitiesClient.McpServerCapabilitiesBulkUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersCapabilitiesClient
    {
        /// <summary>
        /// Bulk Update MCP Server Capabilities
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerCapabilitiesBulkUpdateResponse> McpServerCapabilitiesBulkUpdateAsync(
            string mcpServerId,

            global::G.BulkUpdateMcpServerCapabilities request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Server Capabilities
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="capabilities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerCapabilitiesBulkUpdateResponse> McpServerCapabilitiesBulkUpdateAsync(
            string mcpServerId,
            global::System.Collections.Generic.IList<global::G.BulkUpdateMcpServerCapabilitiesCapabilitie> capabilities,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}