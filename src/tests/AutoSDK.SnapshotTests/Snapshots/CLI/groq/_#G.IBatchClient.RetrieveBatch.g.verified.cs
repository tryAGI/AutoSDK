//HintName: G.IBatchClient.RetrieveBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Retrieves a batch.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Batch> RetrieveBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}