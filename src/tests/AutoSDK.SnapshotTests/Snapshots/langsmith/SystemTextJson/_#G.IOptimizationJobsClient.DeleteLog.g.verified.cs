//HintName: G.IOptimizationJobsClient.DeleteLog.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Delete Log<br/>
        /// Delete a prompt optimization job log.
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteLogAsync(
            global::System.Guid logId,
            string owner,
            string repo,
            string jobId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}