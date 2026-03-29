//HintName: G.ITokensClient.Refresh.g.cs
#nullable enable

namespace G
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Refresh JWT token<br/>
        /// Get a new access token, using a refresh token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenRefreshResponse> RefreshAsync(

            global::G.TokenRefreshRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Refresh JWT token<br/>
        /// Get a new access token, using a refresh token.
        /// </summary>
        /// <param name="refresh">
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenRefreshResponse> RefreshAsync(
            string refresh,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}