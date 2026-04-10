//HintName: G.IRunsClient.RetrieveRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve Run<br/>
        /// Get the status of a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Run> RetrieveRunAsync(
            string runId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}