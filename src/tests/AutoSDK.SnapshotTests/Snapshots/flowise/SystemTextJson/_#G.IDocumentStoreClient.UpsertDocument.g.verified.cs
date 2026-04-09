//HintName: G.IDocumentStoreClient.UpsertDocument.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Upsert document to document store<br/>
        /// Upsert document to document store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorUpsertResponse> UpsertDocumentAsync(
            global::System.Guid id,

            global::G.DocumentStoreLoaderForUpsert request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert document to document store<br/>
        /// Upsert document to document store
        /// </summary>
        /// <param name="id"></param>
        /// <param name="docId">
        /// Document ID within the store. If provided, existing configuration from the document will be used for the new document
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the document<br/>
        /// Example: {"foo":"bar"}
        /// </param>
        /// <param name="replaceExisting">
        /// Whether to replace existing document loader with the new upserted chunks. However this does not delete the existing embeddings in the vector store
        /// </param>
        /// <param name="createNewDocStore">
        /// Whether to create a new document store
        /// </param>
        /// <param name="docStore">
        /// Only when createNewDocStore is true, pass in the new document store configuration
        /// </param>
        /// <param name="loader"></param>
        /// <param name="splitter"></param>
        /// <param name="embedding"></param>
        /// <param name="vectorStore"></param>
        /// <param name="recordManager"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorUpsertResponse> UpsertDocumentAsync(
            global::System.Guid id,
            global::System.Guid? docId = default,
            object? metadata = default,
            bool? replaceExisting = default,
            bool? createNewDocStore = default,
            global::G.DocumentStoreLoaderForUpsertDocStore? docStore = default,
            global::G.DocumentStoreLoaderForUpsertLoader? loader = default,
            global::G.DocumentStoreLoaderForUpsertSplitter? splitter = default,
            global::G.DocumentStoreLoaderForUpsertEmbedding? embedding = default,
            global::G.DocumentStoreLoaderForUpsertVectorStore? vectorStore = default,
            global::G.DocumentStoreLoaderForUpsertRecordManager? recordManager = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}