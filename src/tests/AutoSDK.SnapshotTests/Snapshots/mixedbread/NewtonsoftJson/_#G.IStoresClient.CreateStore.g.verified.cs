//HintName: G.IStoresClient.CreateStore.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Create a store<br/>
        /// Create a new vector store.<br/>
        /// Args:<br/>
        ///     vector_store_create: VectorStoreCreate object containing the name, description, and metadata.<br/>
        /// Returns:<br/>
        ///     VectorStore: The response containing the created vector store details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Store> CreateStoreAsync(

            global::G.StoreCreateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a store<br/>
        /// Create a new vector store.<br/>
        /// Args:<br/>
        ///     vector_store_create: VectorStoreCreate object containing the name, description, and metadata.<br/>
        /// Returns:<br/>
        ///     VectorStore: The response containing the created vector store details.
        /// </summary>
        /// <param name="name">
        /// Name for the new store. Can only contain lowercase letters, numbers, periods (.), and hyphens (-).
        /// </param>
        /// <param name="description">
        /// Description of the store
        /// </param>
        /// <param name="isPublic">
        /// Whether the store can be accessed by anyone with valid login credentials<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expiresAfter">
        /// Optional expiration policy
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs
        /// </param>
        /// <param name="config">
        /// Store-level configuration defaults
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Store> CreateStoreAsync(
            string? name = default,
            string? description = default,
            bool? isPublic = default,
            global::G.ExpiresAfter? expiresAfter = default,
            object? metadata = default,
            global::G.StoreConfig2? config = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}