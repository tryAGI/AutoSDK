//HintName: G.IToolsClient.McpOauthCallback.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Mcp Oauth Callback<br/>
        /// Handle OAuth callback for MCP server authentication.<br/>
        /// Session is identified via the state parameter instead of URL path.
        /// </summary>
        /// <param name="code">
        /// OAuth authorization code
        /// </param>
        /// <param name="state">
        /// OAuth state parameter
        /// </param>
        /// <param name="error">
        /// OAuth error
        /// </param>
        /// <param name="errorDescription">
        /// OAuth error description
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> McpOauthCallbackAsync(
            string? code = default,
            string? state = default,
            string? error = default,
            string? errorDescription = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}