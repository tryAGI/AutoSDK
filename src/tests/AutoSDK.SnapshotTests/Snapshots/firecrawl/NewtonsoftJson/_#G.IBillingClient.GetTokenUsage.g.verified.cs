//HintName: G.IBillingClient.GetTokenUsage.g.cs
#nullable enable

namespace G
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get remaining tokens for the authenticated team (Extract only)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTokenUsageResponse> GetTokenUsageAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}