//HintName: G.ITracesClient.SearchTraces.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Search traces<br/>
        /// Search traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SearchTracesAsync(

            global::G.TraceSearchStreamRequestPublic request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search traces<br/>
        /// Search traces
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="filters"></param>
        /// <param name="lastRetrievedId"></param>
        /// <param name="limit">
        /// Max number of traces to be streamed<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="truncate">
        /// Truncate input, output and metadata to slim payloads<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stripAttachments">
        /// If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments<br/>
        /// Default Value: false
        /// </param>
        /// <param name="fromTime">
        /// Filter traces created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter traces created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SearchTracesAsync(
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::G.TraceFilterPublic>? filters = default,
            global::System.Guid? lastRetrievedId = default,
            int? limit = default,
            bool? truncate = default,
            bool? stripAttachments = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}