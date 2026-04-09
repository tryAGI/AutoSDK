//HintName: G.IMcpIntegrationsCapabilitiesClient.McpIntegrationCapabilitiesBulkUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpIntegrationsCapabilitiesClient
    {
        /// <summary>
        /// Bulk Update MCP Integration Capabilities
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpIntegrationCapabilitiesBulkUpdateResponse> McpIntegrationCapabilitiesBulkUpdateAsync(
            string mcpIntegrationId,

            global::G.BulkUpdateMcpIntegrationCapabilities request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update MCP Integration Capabilities
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="capabilities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpIntegrationCapabilitiesBulkUpdateResponse> McpIntegrationCapabilitiesBulkUpdateAsync(
            string mcpIntegrationId,
            global::System.Collections.Generic.IList<global::G.BulkUpdateMcpIntegrationCapabilitiesCapabilitie> capabilities,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}