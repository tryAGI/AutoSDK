//HintName: G.IRunnersClient.GetJobLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Get local runner job logs<br/>
        /// Get log entries for a local runner job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LocalRunnerLogEntry>> GetJobLogsAsync(
            global::System.Guid jobId,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}