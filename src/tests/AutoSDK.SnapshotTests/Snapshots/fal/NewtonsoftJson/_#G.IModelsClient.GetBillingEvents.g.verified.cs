//HintName: G.IModelsClient.GetBillingEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Billing Events<br/>
        /// Returns paginated individual billing event records with filters<br/>
        /// for endpoint and date range. Each record includes the request ID, timestamp,<br/>
        /// endpoint, and output units billed.<br/>
        /// **Key Features:**<br/>
        /// - Individual billing event records for each API request<br/>
        /// - Flexible date range filtering<br/>
        /// - Optional endpoint filtering<br/>
        /// - Cursor-based pagination for efficient large dataset queries<br/>
        /// - Limited to 100 records per page for performance<br/>
        /// **Common Use Cases:**<br/>
        /// - Audit individual billing events<br/>
        /// - Track request patterns and volumes<br/>
        /// - Debug specific requests by ID<br/>
        /// - Monitor billing unit consumption per request<br/>
        /// See [fal.ai docs](https://docs.fal.ai/model-apis/faq) for more details.<br/>
        ///     
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="requestId">
        /// Filter by specific request ID(s). Accepts 1-50 request IDs. Supports comma-separated values: ?request_id=req1,req2 or array syntax: ?request_id=req1&amp;request_id=req2<br/>
        /// Example: [req-abc123]
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'auth_method' to include authentication method information (formatted with user key aliases).<br/>
        /// Example: auth_method
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetBillingEventsResponse> GetBillingEventsAsync(
            int? limit = default,
            string? cursor = default,
            global::G.AnyOf<global::System.DateTime?, string>? start = default,
            global::G.AnyOf<global::System.DateTime?, string>? end = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? requestId = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}