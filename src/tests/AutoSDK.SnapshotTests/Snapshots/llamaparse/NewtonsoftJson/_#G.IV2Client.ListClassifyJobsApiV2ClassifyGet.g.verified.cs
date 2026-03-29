//HintName: G.IV2Client.ListClassifyJobsApiV2ClassifyGet.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Classify Jobs<br/>
        /// List classify jobs with optional filtering and pagination.<br/>
        /// Filter by `status`, `configuration_id`, specific `job_ids`,<br/>
        /// or creation date range.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="status">
        /// Filter by job status
        /// </param>
        /// <param name="jobIds">
        /// Filter by specific job IDs
        /// </param>
        /// <param name="configurationId">
        /// Filter by configuration ID
        /// </param>
        /// <param name="createdAtOnOrAfter">
        /// Include jobs created at or after this timestamp (inclusive)
        /// </param>
        /// <param name="createdAtOnOrBefore">
        /// Include jobs created at or before this timestamp (inclusive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassifyV2JobQueryResponse> ListClassifyJobsApiV2ClassifyGetAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::G.ListClassifyJobsApiV2ClassifyGetStatus2? status = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            string? configurationId = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}