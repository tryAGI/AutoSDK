//HintName: G.IDocumentStoreClient.GetDocumentStoreFileChunks.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Get chunks from a specific document loader<br/>
        /// Get chunks from a specific document loader within a document store
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="loaderId"></param>
        /// <param name="pageNo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentStoreFileChunkPagedResponse> GetDocumentStoreFileChunksAsync(
            global::System.Guid storeId,
            global::System.Guid loaderId,
            string pageNo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}