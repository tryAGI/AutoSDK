//HintName: G.IConnectedAccountsClient.GetConnectedAccountsByNanoid.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Get connected account details by ID<br/>
        /// Retrieves comprehensive details of a connected account, including authentication configuration, connection status, and all parameters needed for API requests.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConnectedAccountsByNanoidResponse> GetConnectedAccountsByNanoidAsync(
            string nanoid,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}