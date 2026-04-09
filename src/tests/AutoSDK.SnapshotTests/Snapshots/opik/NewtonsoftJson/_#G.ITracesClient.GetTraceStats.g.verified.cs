//HintName: G.ITracesClient.GetTraceStats.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get trace stats<br/>
        /// Get trace stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="filters"></param>
        /// <param name="search">
        /// Full-text search across trace fields
        /// </param>
        /// <param name="fromTime">
        /// Filter traces created from this time (ISO-8601 format).
        /// </param>
        /// <param name="toTime">
        /// Filter traces created up to this time (ISO-8601 format). If not provided, defaults to current time. Must be after 'from_time'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectStatsPublic> GetTraceStatsAsync(
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? filters = default,
            string? search = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}