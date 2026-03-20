//HintName: G.IOptimizationJobsClient.GetLog.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Get Log<br/>
        /// Get a specific prompt optimization job log.
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptOptimizationJobLog> GetLogAsync(
            global::System.Guid logId,
            string owner,
            string repo,
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}