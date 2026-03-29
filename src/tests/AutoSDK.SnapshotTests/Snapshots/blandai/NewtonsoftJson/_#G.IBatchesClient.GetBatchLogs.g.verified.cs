//HintName: G.IBatchesClient.GetBatchLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Get Batch Logs<br/>
        /// Retrieve lifecycle and event logs for a specific batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataResponseBatchLogs> GetBatchLogsAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}