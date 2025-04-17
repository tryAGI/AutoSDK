//HintName: G.IBatchClient.JobsApiRoutesBatchCancelBatchJob.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Cancel Batch Job<br/>
        /// Request the cancellation of a batch job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobOut> JobsApiRoutesBatchCancelBatchJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}