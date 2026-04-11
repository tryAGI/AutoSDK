//HintName: G.ISpansClient.GetSpansByProject.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Get spans by project_name or project_id and optionally by trace_id and/or type<br/>
        /// Get spans by project_name or project_id and optionally by trace_id and/or type
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        /// <param name="truncate">
        /// Truncate input, output and metadata to slim payloads<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stripAttachments">
        /// If true, returns attachment references like [file.png]; if false, downloads and reinjects stripped attachments<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="exclude"></param>
        /// <param name="search">
        /// Full-text search across span fields
        /// </param>
        /// <param name="fromTime">
        /// Filter spans created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter spans created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpanPagePublic> GetSpansByProjectAsync(
            int? page = default,
            int? size = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::System.Guid? traceId = default,
            global::G.GetSpansByProjectType? type = default,
            string? filters = default,
            bool? truncate = default,
            bool? stripAttachments = default,
            string? sorting = default,
            string? exclude = default,
            string? search = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}