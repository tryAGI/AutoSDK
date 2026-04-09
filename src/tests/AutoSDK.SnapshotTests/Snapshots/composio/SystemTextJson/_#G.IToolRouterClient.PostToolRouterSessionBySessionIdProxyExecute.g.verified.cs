//HintName: G.IToolRouterClient.PostToolRouterSessionBySessionIdProxyExecute.g.cs
#nullable enable

namespace G
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Execute proxy request within a tool router session<br/>
        /// Execute any native API call on a toolkit with authentication automatically injected from Composio. This endpoint proxies HTTP requests to third-party APIs using connected account credentials resolved from the session context. Provide the toolkit slug, API endpoint, and HTTP method — Composio handles authentication injection, abstracting away credential management. Supports all HTTP methods, custom headers/query parameters, and binary request/response bodies.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdProxyExecuteResponse> PostToolRouterSessionBySessionIdProxyExecuteAsync(
            string? sessionId,

            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute proxy request within a tool router session<br/>
        /// Execute any native API call on a toolkit with authentication automatically injected from Composio. This endpoint proxies HTTP requests to third-party APIs using connected account credentials resolved from the session context. Provide the toolkit slug, API endpoint, and HTTP method — Composio handles authentication injection, abstracting away credential management. Supports all HTTP methods, custom headers/query parameters, and binary request/response bodies.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="toolkitSlug">
        /// The slug of the toolkit to use for the request<br/>
        /// Example: gmail
        /// </param>
        /// <param name="endpoint">
        /// The API endpoint to call (absolute URL or path relative to base URL of the connected account)<br/>
        /// Example: /api/v1/resources
        /// </param>
        /// <param name="method">
        /// The HTTP method to use for the request<br/>
        /// Example: GET
        /// </param>
        /// <param name="body">
        /// The request body (for POST, PUT, and PATCH requests)<br/>
        /// Example: {"name":"New Resource","description":"This is a new resource"}
        /// </param>
        /// <param name="binaryBody">
        /// Binary body to send. For binary upload via URL: use {url: "https://...", content_type?: "..."}. For binary upload via base64: use {base64: "...", content_type?: "..."}.
        /// </param>
        /// <param name="parameters">
        /// Additional HTTP headers or query parameters to include in the request<br/>
        /// Example: [{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]
        /// </param>
        /// <param name="customConnectionData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolRouterSessionBySessionIdProxyExecuteResponse> PostToolRouterSessionBySessionIdProxyExecuteAsync(
            string? sessionId,
            string toolkitSlug,
            string endpoint,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod method,
            object? body = default,
            global::G.AnyOf<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2>? binaryBody = default,
            global::System.Collections.Generic.IList<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>? parameters = default,
            global::G.OneOf<global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10, global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11>? customConnectionData = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}