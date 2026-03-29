//HintName: G.IMessagesClient.CancelBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Cancel Batch<br/>
        /// Cancel a batch run.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}