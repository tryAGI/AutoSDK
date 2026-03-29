//HintName: G.IV2Client.ListExtractJobsApiV2ExtractGet.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
        /// <summary>
        /// List Extract Jobs<br/>
        /// List extraction jobs with optional filtering and pagination.<br/>
        /// Filter by `configuration_id`, `status`, `document_input_value`,<br/>
        /// or creation date range. Results are returned newest-first.<br/>
        /// Use `expand=configuration` to include the full configuration used,<br/>
        /// and `expand=extract_metadata` for per-field metadata.
        /// </summary>
        /// <param name="configurationId">
        /// Filter by configuration ID
        /// </param>
        /// <param name="documentInputType">
        /// Filter by document input type (file_id or parse_job_id)
        /// </param>
        /// <param name="documentInputValue">
        /// Filter by document input value
        /// </param>
        /// <param name="status">
        /// Filter by status
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
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
        /// <param name="expand">
        /// Additional fields to include: configuration, extract_metadata
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractV2JobQueryResponse> ListExtractJobsApiV2ExtractGetAsync(
            string? configurationId = default,
            string? documentInputType = default,
            string? documentInputValue = default,
            global::G.ListExtractJobsApiV2ExtractGetStatus2? status = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.DateTime? createdAtOnOrAfter = default,
            global::System.DateTime? createdAtOnOrBefore = default,
            global::System.Collections.Generic.IList<string>? jobIds = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}