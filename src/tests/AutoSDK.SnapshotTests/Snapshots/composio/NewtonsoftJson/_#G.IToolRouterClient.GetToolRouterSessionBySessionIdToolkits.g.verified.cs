//HintName: G.IToolRouterClient.GetToolRouterSessionBySessionIdToolkits.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Get toolkits for a tool router session<br/>
        /// Retrieves a cursor-paginated list of toolkits available in the tool router session. Includes toolkit metadata, composio-managed auth schemes, and connected accounts if available. Optionally filter by specific toolkit slugs.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_123456789
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="toolkits">
        /// Filter toolkits by specific slugs (comma-separated). Overrides session toolkit configuration if provided.<br/>
        /// Example: gmail,slack,github
        /// </param>
        /// <param name="isConnected">
        /// Whether to filter by connected toolkits. If provided, only connected toolkits will be returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="search">
        /// Search query to filter toolkits by name, slug, or description<br/>
        /// Example: gmail
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToolRouterToolkitsListResponse> GetToolRouterSessionBySessionIdToolkitsAsync(
            string sessionId,
            double? limit = default,
            string? cursor = default,
            global::System.Collections.Generic.IList<string>? toolkits = default,
            bool? isConnected = default,
            string? search = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}