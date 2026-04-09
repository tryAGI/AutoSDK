//HintName: G.ILoginClient.UnsafeLogin.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Unsafe Login to Dedoose API<br/>
        /// Authenticates a user and returns an access token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnsafeLoginAsync(

            global::G.UnsafeLoginRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unsafe Login to Dedoose API<br/>
        /// Authenticates a user and returns an access token.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UnsafeLoginAsync(
            string username,
            string password,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}