//HintName: G.IRunnersClient.GetJob.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Get local runner job<br/>
        /// Get a single local runner job's status and results
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LocalRunnerJob> GetJobAsync(
            global::System.Guid jobId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}