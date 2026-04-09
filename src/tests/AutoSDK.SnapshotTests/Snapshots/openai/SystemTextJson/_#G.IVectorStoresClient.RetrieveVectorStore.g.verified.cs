//HintName: G.IVectorStoresClient.RetrieveVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Retrieves a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreObject> RetrieveVectorStoreAsync(
            string vectorStoreId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}