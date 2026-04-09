//HintName: G.IToolRouterClient.PostLabsToolRouterSession.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Create a new tool router session (Legacy)<br/>
        /// Creates a new session for the tool router lab feature (Legacy). This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostLabsToolRouterSessionResponse> PostLabsToolRouterSessionAsync(

            global::G.PostLabsToolRouterSessionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new tool router session (Legacy)<br/>
        /// Creates a new session for the tool router lab feature (Legacy). This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="userId">
        /// Unique user identifier for the session owner<br/>
        /// Example: user_123456789
        /// </param>
        /// <param name="config">
        /// Session configuration including enabled toolkits and their auth configs<br/>
        /// Default Value: {}<br/>
        /// Example: {"manually_manage_connections":false,"toolkits":[{"toolkit":"gmail","auth_config_id":"auth_config_123"},{"toolkit":"slack"}]}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostLabsToolRouterSessionResponse> PostLabsToolRouterSessionAsync(
            string userId,
            global::G.PostLabsToolRouterSessionRequestConfig? config = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}