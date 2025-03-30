//HintName: G.IOptimizationJobsClient.UpdateJob.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Update Job<br/>
        /// Replace an existing prompt optimization job with a new, modified job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptOptimizationJob> UpdateJobAsync(
            global::System.Guid jobId,
            string owner,
            string repo,
            global::G.PromptOptimizationJobUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Job<br/>
        /// Replace an existing prompt optimization job with a new, modified job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptOptimizationJob> UpdateJobAsync(
            global::System.Guid jobId,
            string owner,
            string repo,
            global::G.EPromptOptimizationJobStatus? status = default,
            global::G.PromptOptimizationResult? result = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}