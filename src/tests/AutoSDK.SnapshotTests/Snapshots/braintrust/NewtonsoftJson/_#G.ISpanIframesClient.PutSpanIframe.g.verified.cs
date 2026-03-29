//HintName: G.ISpanIframesClient.PutSpanIframe.g.cs
#nullable enable

namespace G
{
    public partial interface ISpanIframesClient
    {
        /// <summary>
        /// Create or replace span_iframe<br/>
        /// Create or replace span_iframe. If there is an existing span_iframe with the same name as the one specified in the request, will replace the existing span_iframe with the provided fields
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpanIFrame> PutSpanIframeAsync(

            global::G.CreateSpanIFrame request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or replace span_iframe<br/>
        /// Create or replace span_iframe. If there is an existing span_iframe with the same name as the one specified in the request, will replace the existing span_iframe with the provided fields
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the span iframe belongs under
        /// </param>
        /// <param name="name">
        /// Name of the span iframe
        /// </param>
        /// <param name="description">
        /// Textual description of the span iframe
        /// </param>
        /// <param name="url">
        /// URL to embed the project viewer in an iframe
        /// </param>
        /// <param name="postMessage">
        /// Whether to post messages to the iframe containing the span's data. This is useful when you want to render more data than fits in the URL.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpanIFrame> PutSpanIframeAsync(
            global::System.Guid projectId,
            string name,
            string url,
            string? description = default,
            bool? postMessage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}