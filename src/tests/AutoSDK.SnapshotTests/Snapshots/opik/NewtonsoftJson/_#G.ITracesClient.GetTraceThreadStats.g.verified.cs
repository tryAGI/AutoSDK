//HintName: G.ITracesClient.GetTraceThreadStats.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get trace thread stats<br/>
        /// Get trace thread stats
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="filters"></param>
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
        global::System.Threading.Tasks.Task<global::G.ProjectStatsPublic> GetTraceThreadStatsAsync(
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? filters = default,
            string? search = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}