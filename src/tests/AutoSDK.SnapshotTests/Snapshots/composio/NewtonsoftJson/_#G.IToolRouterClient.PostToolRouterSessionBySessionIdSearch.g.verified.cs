//HintName: G.IToolRouterClient.PostToolRouterSessionBySessionIdSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Search for tools using a query<br/>
        /// Search for tools matching a given use case query within a tool router session. Returns matching tool slugs, full tool schemas, toolkit connection statuses, and workflow guidance in a predictable format.
        /// </summary>
        /// <param name="sessionId">
        /// Tool router session ID (trs_*)<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdSearchResponse> PostToolRouterSessionBySessionIdSearchAsync(
            string sessionId,

            global::G.PostToolRouterSessionBySessionIdSearchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for tools using a query<br/>
        /// Search for tools matching a given use case query within a tool router session. Returns matching tool slugs, full tool schemas, toolkit connection statuses, and workflow guidance in a predictable format.
        /// </summary>
        /// <param name="sessionId">
        /// Tool router session ID (trs_*)<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="queries">
        /// List of search queries to execute in parallel. Up to 7 queries supported.<br/>
        /// Example: [{"use_case":"Send a slack message to a channel"}]
        /// </param>
        /// <param name="model">
        /// Optional model hint for search/planning behavior (e.g., "gpt-4o"). Ignored if invalid.<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdSearchResponse> PostToolRouterSessionBySessionIdSearchAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdSearchRequestQuerie> queries,
            string? model = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}