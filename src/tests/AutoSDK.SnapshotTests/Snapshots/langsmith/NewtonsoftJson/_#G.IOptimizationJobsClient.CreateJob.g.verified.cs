//HintName: G.IOptimizationJobsClient.CreateJob.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Create Job<br/>
        /// Create a new prompt optimization job.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptOptimizationJob> CreateJobAsync(
            string repo,
            string owner,
            global::G.PromptOptimizationJobCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Job<br/>
        /// Create a new prompt optimization job.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptOptimizationJob> CreateJobAsync(
            string repo,
            string owner,
            global::G.EPromptOptimizationAlgorithm algorithm,
            global::G.AnyOf<global::G.PromptimConfig, global::G.DemoConfig> config,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}