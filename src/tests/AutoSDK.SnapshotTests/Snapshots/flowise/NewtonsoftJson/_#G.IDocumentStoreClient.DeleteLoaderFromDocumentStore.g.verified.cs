//HintName: G.IDocumentStoreClient.DeleteLoaderFromDocumentStore.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Delete specific document loader and associated chunks from document store<br/>
        /// Delete specific document loader and associated chunks from document store. This does not delete data from vector store.
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="loaderId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLoaderFromDocumentStoreAsync(
            string storeId,
            string loaderId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}