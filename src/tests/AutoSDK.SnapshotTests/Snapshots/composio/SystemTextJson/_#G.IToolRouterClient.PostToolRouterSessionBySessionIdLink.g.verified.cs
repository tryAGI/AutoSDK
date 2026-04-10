//HintName: G.IToolRouterClient.PostToolRouterSessionBySessionIdLink.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Create a link session for a toolkit in a tool router session<br/>
        /// Initiates an authentication link session for a specific toolkit within a tool router session. Returns a link token and redirect URL that users can use to complete the OAuth flow.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdLinkResponse> PostToolRouterSessionBySessionIdLinkAsync(
            string sessionId,

            global::G.PostToolRouterSessionBySessionIdLinkRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a link session for a toolkit in a tool router session<br/>
        /// Initiates an authentication link session for a specific toolkit within a tool router session. Returns a link token and redirect URL that users can use to complete the OAuth flow.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="toolkit">
        /// The unique slug identifier of the toolkit to connect<br/>
        /// Example: github
        /// </param>
        /// <param name="callbackUrl">
        /// URL where users will be redirected after completing auth<br/>
        /// Example: https://myapp.com/callback
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdLinkResponse> PostToolRouterSessionBySessionIdLinkAsync(
            string sessionId,
            string toolkit,
            string? callbackUrl = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}