//HintName: G.IConnectedAccountsClient.PostConnectedAccountsByNanoidRefresh.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Refresh authentication for a connected account<br/>
        /// Initiates a new authentication flow for a connected account when credentials have expired or become invalid. This may generate a new authentication URL for OAuth flows or refresh tokens for other auth schemes.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostConnectedAccountsByNanoidRefreshResponse> PostConnectedAccountsByNanoidRefreshAsync(
            string nanoid,

            global::G.PostConnectedAccountsByNanoidRefreshRequest request,
            string? redirectUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Refresh authentication for a connected account<br/>
        /// Initiates a new authentication flow for a connected account when credentials have expired or become invalid. This may generate a new authentication URL for OAuth flows or refresh tokens for other auth schemes.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="requestRedirectUrl"></param>
        /// <param name="validateCredentials">
        /// [EXPERIMENTAL] Whether to validate the provided credentials, validates only for API Key Auth scheme<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostConnectedAccountsByNanoidRefreshResponse> PostConnectedAccountsByNanoidRefreshAsync(
            string nanoid,
            string? redirectUrl = default,
            string? requestRedirectUrl = default,
            bool? validateCredentials = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}