//HintName: G.IBetaClient.GetBatchJobStatusApiV1BetaBatchProcessingJobIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Get Batch Job Status<br/>
        /// Get detailed status of a batch processing job.<br/>
        /// Returns current progress percentage, file counts (total,<br/>
        /// processed, failed, skipped), and timestamps.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobStatusResponse> GetBatchJobStatusApiV1BetaBatchProcessingJobIdGetAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}