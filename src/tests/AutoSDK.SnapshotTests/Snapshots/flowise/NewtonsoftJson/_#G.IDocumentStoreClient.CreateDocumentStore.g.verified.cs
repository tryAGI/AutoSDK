//HintName: G.IDocumentStoreClient.CreateDocumentStore.g.cs
#nullable enable

namespace G
{
    public partial interface IDocumentStoreClient
    {
        /// <summary>
        /// Create a new document store<br/>
        /// Creates a new document store with the provided details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentStore> CreateDocumentStoreAsync(

            global::G.DocumentStore request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new document store<br/>
        /// Creates a new document store with the provided details
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the document store
        /// </param>
        /// <param name="name">
        /// Name of the document store
        /// </param>
        /// <param name="description">
        /// Description of the document store
        /// </param>
        /// <param name="loaders">
        /// Loaders associated with the document store, stored as JSON string
        /// </param>
        /// <param name="whereUsed">
        /// Places where the document store is used, stored as JSON string
        /// </param>
        /// <param name="status">
        /// Status of the document store
        /// </param>
        /// <param name="vectorStoreConfig">
        /// Configuration for the vector store, stored as JSON string
        /// </param>
        /// <param name="embeddingConfig">
        /// Configuration for the embedding, stored as JSON string
        /// </param>
        /// <param name="recordManagerConfig">
        /// Configuration for the record manager, stored as JSON string
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the document store was created
        /// </param>
        /// <param name="updatedDate">
        /// Date and time when the document store was last updated
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DocumentStore> CreateDocumentStoreAsync(
            global::System.Guid? id = default,
            string? name = default,
            string? description = default,
            string? loaders = default,
            string? whereUsed = default,
            global::G.DocumentStoreStatus? status = default,
            string? vectorStoreConfig = default,
            string? embeddingConfig = default,
            string? recordManagerConfig = default,
            global::System.DateTime? createdDate = default,
            global::System.DateTime? updatedDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}