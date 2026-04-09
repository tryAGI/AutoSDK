//HintName: G.ISubpackageCreditsClient.GetCredits.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageCreditsClient
    {
        /// <summary>
        /// Get remaining credits<br/>
        /// Get total credits purchased and used for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreditsGetCreditsResponse200> GetCreditsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}