//HintName: G.IToolRouterClient.GetToolRouterSessionBySessionId.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Get a tool router session by ID<br/>
        /// Retrieves an existing tool router session by its ID. Returns the session configuration, MCP server URL, and available tools.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_123456789
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetToolRouterSessionBySessionIdResponse> GetToolRouterSessionBySessionIdAsync(
            string sessionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}