//HintName: G.IMcpIntegrationsClient.McpIntegrationsRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpIntegrationsClient
    {
        /// <summary>
        /// Get MCP Integration
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpIntegration> McpIntegrationsRetrieveAsync(
            string mcpIntegrationId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}