//HintName: G.IMcpIntegrationsClient.McpIntegrationsList.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpIntegrationsClient
    {
        /// <summary>
        /// List MCP Integrations<br/>
        /// List MCP Integrations for the organisation or workspace. Requires organisation_id (when using org admin API key) or x-portkey-api-key header.
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="type"></param>
        /// <param name="workspaceId"></param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="currentPage">
        /// Default Value: 0
        /// </param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpIntegrationListResponse> McpIntegrationsListAsync(
            global::System.Guid? organisationId = default,
            global::G.McpIntegrationsListType? type = default,
            string? workspaceId = default,
            int? pageSize = default,
            int? currentPage = default,
            string? search = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}