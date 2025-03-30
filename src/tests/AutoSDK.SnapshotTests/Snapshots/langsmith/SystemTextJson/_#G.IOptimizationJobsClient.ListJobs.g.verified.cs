//HintName: G.IOptimizationJobsClient.ListJobs.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// List Jobs<br/>
        /// List all prompt optimization jobs.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PromptOptimizationJob>> ListJobsAsync(
            string repo,
            string owner,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}