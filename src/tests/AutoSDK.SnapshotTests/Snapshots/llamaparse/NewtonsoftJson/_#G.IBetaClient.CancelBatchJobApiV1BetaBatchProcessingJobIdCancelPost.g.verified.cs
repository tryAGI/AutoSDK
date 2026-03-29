//HintName: G.IBetaClient.CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Cancel Batch Job<br/>
        /// Cancel a running batch processing job.<br/>
        /// Stops processing and marks pending items as cancelled.<br/>
        /// Items currently being processed may still complete.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="temporalNamespace"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobCancelResponse> CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostAsync(
            string jobId,

            global::G.BatchJobCancelRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? temporalNamespace = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Batch Job<br/>
        /// Cancel a running batch processing job.<br/>
        /// Stops processing and marks pending items as cancelled.<br/>
        /// Items currently being processed may still complete.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="temporalNamespace"></param>
        /// <param name="session"></param>
        /// <param name="reason">
        /// Optional reason for cancelling the job
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobCancelResponse> CancelBatchJobApiV1BetaBatchProcessingJobIdCancelPostAsync(
            string jobId,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? temporalNamespace = default,
            string? session = default,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}