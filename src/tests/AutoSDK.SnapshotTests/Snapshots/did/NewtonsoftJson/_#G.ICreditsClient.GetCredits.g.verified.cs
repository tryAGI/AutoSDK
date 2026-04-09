//HintName: G.ICreditsClient.GetCredits.g.cs
#nullable enable

namespace G
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// Get credits<br/>
        /// Get the user's credits items each credit item contains the remaining and total credits for the user<br/>
        /// With the time expiration of the credits
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCreditsResponse> GetCreditsAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}