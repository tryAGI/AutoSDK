//HintName: G.IV2Client.ListParseJobsApiV2ParseGet.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Parse Jobs<br/>
        /// List parse jobs for the current project.<br/>
        /// Filter by `status` or creation date range. Results are<br/>
        /// paginated — use `page_token` from the response to fetch<br/>
        /// subsequent pages.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="status">
        /// Filter by job status (PENDING, RUNNING, COMPLETED, FAILED, CANCELLED)
        /// </param>
        /// <param name="createdAtOnOrAfter">
        /// Include jobs created at or after this timestamp (inclusive)
        /// </param>
        /// <param name="createdAtOnOrBefore">
        /// Include jobs created at or before this timestamp (inclusive)
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseJobQueryResponse> ListParseJobsApiV2ParseGetAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::G.ListParseJobsApiV2ParseGetStatus2? status = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}