//HintName: G.ILogsClient.GetRunLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get Run Logs<br/>
        /// Get the pipeline logs for a run
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetRunLogsAsync(
            string runId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}