//HintName: G.ISpansClient.GetSpanStats.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Get span stats<br/>
        /// Get span stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="traceId"></param>
        /// <param name="type"></param>
        /// <param name="filters"></param>
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
        global::System.Threading.Tasks.Task<global::G.ProjectStatsPublic> GetSpanStatsAsync(
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::System.Guid? traceId = default,
            global::G.GetSpanStatsType? type = default,
            string? filters = default,
            string? search = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}