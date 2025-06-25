//HintName: G.IVectorStoresClient.ListFilesInVectorStoreBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Returns a list of vector store files in a batch.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="batchId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListVectorStoreFilesResponse> ListFilesInVectorStoreBatchAsync(
            string vectorStoreId,
            string batchId,
            int? limit = default,
            global::G.ListFilesInVectorStoreBatchOrder? order = default,
            string? after = default,
            string? before = default,
            global::G.ListFilesInVectorStoreBatchFilter? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}