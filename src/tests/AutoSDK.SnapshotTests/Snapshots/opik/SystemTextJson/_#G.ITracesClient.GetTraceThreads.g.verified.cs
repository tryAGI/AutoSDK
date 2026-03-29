//HintName: G.ITracesClient.GetTraceThreads.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get trace threads<br/>
        /// Get trace threads
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="truncate">
        /// Truncate input, output and metadata to slim payloads<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stripAttachments">
        /// If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="search">
        /// Full-text search across thread fields
        /// </param>
        /// <param name="fromTime">
        /// Filter trace threads created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter trace threads created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TraceThreadPage> GetTraceThreadsAsync(
            int? page = default,
            int? size = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            bool? truncate = default,
            bool? stripAttachments = default,
            string? filters = default,
            string? sorting = default,
            string? search = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}