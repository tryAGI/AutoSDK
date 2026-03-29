//HintName: G.IBetaClient.ListBatchJobsApiV1BetaBatchProcessingGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Batch Jobs<br/>
        /// List batch processing jobs with optional filtering.<br/>
        /// Filter by `directory_id`, `job_type`, or `status`. Results<br/>
        /// are paginated with configurable `limit` and `offset`.
        /// </summary>
        /// <param name="directoryId">
        /// Filter by directory ID
        /// </param>
        /// <param name="jobType">
        /// Filter by job type (PARSE, EXTRACT, CLASSIFY)
        /// </param>
        /// <param name="status">
        /// Filter by job status (PENDING, RUNNING, COMPLETED, FAILED, CANCELLED)
        /// </param>
        /// <param name="limit">
        /// Maximum number of jobs to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Number of jobs to skip for pagination<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobQueryResponse> ListBatchJobsApiV1BetaBatchProcessingGetAsync(
            string? directoryId = default,
            global::G.BatchJobType? jobType = default,
            global::G.BatchJobStatus? status = default,
            int? limit = default,
            int? offset = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}