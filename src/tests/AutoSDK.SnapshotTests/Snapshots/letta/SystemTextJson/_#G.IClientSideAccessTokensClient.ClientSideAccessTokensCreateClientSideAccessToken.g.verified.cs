//HintName: G.IClientSideAccessTokensClient.ClientSideAccessTokensCreateClientSideAccessToken.g.cs
#nullable enable

namespace G
{
    public partial interface IClientSideAccessTokensClient
    {
        /// <summary>
        /// Create token  (Cloud-only)<br/>
        /// Create a new client side access token with the specified configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponse> ClientSideAccessTokensCreateClientSideAccessTokenAsync(

            global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create token  (Cloud-only)<br/>
        /// Create a new client side access token with the specified configuration.
        /// </summary>
        /// <param name="policy"></param>
        /// <param name="hostname">
        /// The hostname of the client side application. Please specify the full URL including the protocol (http or https).
        /// </param>
        /// <param name="expiresAt">
        /// The expiration date of the token. If not provided, the token will expire in 5 minutes
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponse> ClientSideAccessTokensCreateClientSideAccessTokenAsync(
            global::System.Collections.Generic.IList<global::G.PolicyItem> policy,
            string hostname,
            string? expiresAt = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}