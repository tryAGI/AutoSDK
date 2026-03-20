//HintName: G.IOptimizationJobsClient.GetJob.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Get Job<br/>
        /// Get a specific optimization job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptOptimizationJobWithLogs> GetJobAsync(
            global::System.Guid jobId,
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}