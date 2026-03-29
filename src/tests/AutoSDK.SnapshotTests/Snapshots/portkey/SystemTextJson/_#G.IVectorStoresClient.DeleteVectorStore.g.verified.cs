//HintName: G.IVectorStoresClient.DeleteVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Delete a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteVectorStoreResponse> DeleteVectorStoreAsync(
            string vectorStoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}