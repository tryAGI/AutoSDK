//HintName: G.IClientSideAccessTokensClient.ClientSideAccessTokensDeleteClientSideAccessToken.g.cs
#nullable enable

namespace G
{
    public partial interface IClientSideAccessTokensClient
    {
        /// <summary>
        /// Delete token  (Cloud-only)<br/>
        /// Delete a client side access token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ClientSideAccessTokensDeleteClientSideAccessTokenAsync(
            string token,

            object request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete token  (Cloud-only)<br/>
        /// Delete a client side access token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ClientSideAccessTokensDeleteClientSideAccessTokenAsync(
            string token,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}