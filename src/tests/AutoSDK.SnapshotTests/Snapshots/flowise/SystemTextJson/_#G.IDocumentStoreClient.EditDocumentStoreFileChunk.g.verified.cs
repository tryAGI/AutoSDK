//HintName: G.IDocumentStoreClient.EditDocumentStoreFileChunk.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Update a specific chunk<br/>
        /// Updates a specific chunk from a document loader
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="loaderId"></param>
        /// <param name="chunkId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentStoreFileChunkPagedResponse> EditDocumentStoreFileChunkAsync(
            string storeId,
            string loaderId,
            string chunkId,

            global::G.Document request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a specific chunk<br/>
        /// Updates a specific chunk from a document loader
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="loaderId"></param>
        /// <param name="chunkId"></param>
        /// <param name="pageContent">
        /// Example: This is the content of the page.
        /// </param>
        /// <param name="metadata">
        /// Example: {"author":"John Doe","date":"2024-08-24"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentStoreFileChunkPagedResponse> EditDocumentStoreFileChunkAsync(
            string storeId,
            string loaderId,
            string chunkId,
            string? pageContent = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}