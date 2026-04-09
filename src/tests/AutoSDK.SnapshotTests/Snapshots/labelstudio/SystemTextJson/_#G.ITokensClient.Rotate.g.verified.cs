//HintName: G.ITokensClient.Rotate.g.cs
#nullable enable

namespace G
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Rotate JWT refresh token<br/>
        /// Creates a new JWT refresh token and blacklists the current one.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenRotateResponse> RotateAsync(

            global::G.LSAPITokenRotateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate JWT refresh token<br/>
        /// Creates a new JWT refresh token and blacklists the current one.
        /// </summary>
        /// <param name="refresh"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenRotateResponse> RotateAsync(
            string refresh,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}