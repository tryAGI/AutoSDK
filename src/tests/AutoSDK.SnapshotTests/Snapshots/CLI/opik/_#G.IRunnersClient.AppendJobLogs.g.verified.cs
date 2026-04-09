//HintName: G.IRunnersClient.AppendJobLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Append local runner job logs<br/>
        /// Append log entries for a running local runner job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AppendJobLogsAsync(
            global::System.Guid jobId,

            global::System.Collections.Generic.IList<global::G.LocalRunnerLogEntry> request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}