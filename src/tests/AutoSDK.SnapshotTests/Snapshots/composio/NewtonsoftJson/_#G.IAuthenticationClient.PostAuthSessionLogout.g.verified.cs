//HintName: G.IAuthenticationClient.PostAuthSessionLogout.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthenticationClient
    {
        /// <summary>
        /// End user session and clear authentication<br/>
        /// Terminates the current user session by invalidating authentication cookies and tokens. This effectively signs the user out of the application. After logout, the user will need to authenticate again to access protected resources.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostAuthSessionLogoutResponse> PostAuthSessionLogoutAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}