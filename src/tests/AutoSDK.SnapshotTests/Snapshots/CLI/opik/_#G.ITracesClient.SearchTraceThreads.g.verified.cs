//HintName: G.ITracesClient.SearchTraceThreads.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Search trace threads<br/>
        /// Search trace threads
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SearchTraceThreadsAsync(

            global::G.TraceThreadSearchStreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search trace threads<br/>
        /// Search trace threads
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="filters"></param>
        /// <param name="lastRetrievedThreadModelId"></param>
        /// <param name="limit">
        /// Max number of trace thread to be streamed<br/>
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
        /// Filter trace threads created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter trace threads created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SearchTraceThreadsAsync(
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilter>? filters = default,
            global::System.Guid? lastRetrievedThreadModelId = default,
            int? limit = default,
            bool? truncate = default,
            bool? stripAttachments = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}