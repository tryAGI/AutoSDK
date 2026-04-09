//HintName: G.IProvidersClient.GetProviders.g.cs
#nullable enable

namespace G
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// List All Providers
        /// </summary>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetProvidersResponse> GetProvidersAsync(
            int? currentPage = default,
            int? pageSize = default,
            string? workspaceId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}