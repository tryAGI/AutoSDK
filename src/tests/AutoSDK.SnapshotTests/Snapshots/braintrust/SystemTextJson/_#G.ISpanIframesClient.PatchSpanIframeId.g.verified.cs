//HintName: G.ISpanIframesClient.PatchSpanIframeId.g.cs
#nullable enable

namespace G
{
    public partial interface ISpanIframesClient
    {
        /// <summary>
        /// Partially update span_iframe<br/>
        /// Partially update a span_iframe object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="spanIframeId">
        /// SpanIframe id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpanIFrame> PatchSpanIframeIdAsync(
            global::System.Guid spanIframeId,

            global::G.PatchSpanIFrame request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update span_iframe<br/>
        /// Partially update a span_iframe object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="spanIframeId">
        /// SpanIframe id
        /// </param>
        /// <param name="name">
        /// Name of the span iframe
        /// </param>
        /// <param name="url">
        /// URL to embed the project viewer in an iframe
        /// </param>
        /// <param name="postMessage">
        /// Whether to post messages to the iframe containing the span's data. This is useful when you want to render more data than fits in the URL.
        /// </param>
        /// <param name="description">
        /// Textual description of the span iframe
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpanIFrame> PatchSpanIframeIdAsync(
            global::System.Guid spanIframeId,
            string? name = default,
            string? url = default,
            bool? postMessage = default,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}