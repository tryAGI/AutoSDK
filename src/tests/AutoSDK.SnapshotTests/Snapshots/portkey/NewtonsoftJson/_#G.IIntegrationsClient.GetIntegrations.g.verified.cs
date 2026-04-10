//HintName: G.IIntegrationsClient.GetIntegrations.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List All Integrations
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="workspaceId"></param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetIntegrationsResponse> GetIntegrationsAsync(
            int? currentPage = default,
            int? pageSize = default,
            string? workspaceId = default,
            global::G.GetIntegrationsType? type = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}