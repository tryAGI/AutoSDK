//HintName: G.IRunsClient.RetrieveMetricsForRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve Metrics For Run<br/>
        /// Get run metrics by run ID.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunMetrics> RetrieveMetricsForRunAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}