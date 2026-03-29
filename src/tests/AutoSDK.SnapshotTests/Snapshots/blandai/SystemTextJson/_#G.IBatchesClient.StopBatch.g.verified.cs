//HintName: G.IBatchesClient.StopBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchesClient
    {
        /// <summary>
        /// Stop Batch<br/>
        /// Halt a batch that is currently running or scheduled.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataResponseNull> StopBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}