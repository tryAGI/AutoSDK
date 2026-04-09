//HintName: G.IMcpIntegrationsCapabilitiesClient.McpIntegrationCapabilitiesList.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpIntegrationsCapabilitiesClient
    {
        /// <summary>
        /// List MCP Integration Capabilities
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="type"></param>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpIntegrationCapabilitiesListResponse> McpIntegrationCapabilitiesListAsync(
            string mcpIntegrationId,
            int? page = default,
            int? pageSize = default,
            global::G.McpIntegrationCapabilitiesListType? type = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}