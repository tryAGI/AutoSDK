//HintName: G.ISpansClient.SearchSpans.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Search spans<br/>
        /// Search spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SearchSpansAsync(

            global::G.SpanSearchStreamRequestPublic request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search spans<br/>
        /// Search spans
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        /// <param name="limit">
        /// Max number of spans to be streamed<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata<br/>
        /// Default Value: true
        /// </param>
        /// <param name="fromTime">
        /// Filter spans created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter spans created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SearchSpansAsync(
            global::System.Guid? traceId = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::G.SpanSearchStreamRequestPublicType? type = default,
            global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? filters = default,
            int? limit = default,
            global::System.Guid? lastRetrievedId = default,
            bool? truncate = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}