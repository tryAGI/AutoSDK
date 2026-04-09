//HintName: G.ISpansClient.BatchUpdateSpans.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Batch update spans<br/>
        /// Update multiple spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateSpansAsync(

            global::G.SpanBatchUpdate request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update spans<br/>
        /// Update multiple spans
        /// </summary>
        /// <param name="ids">
        /// List of span IDs to update (max 1000)
        /// </param>
        /// <param name="update"></param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateSpansAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.SpanUpdate update,
            bool? mergeTags = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}