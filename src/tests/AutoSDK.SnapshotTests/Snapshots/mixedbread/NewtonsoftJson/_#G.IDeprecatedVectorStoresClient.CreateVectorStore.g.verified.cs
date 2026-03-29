//HintName: G.IDeprecatedVectorStoresClient.CreateVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Create a vector store<br/>
        /// DEPRECATED: Use POST /stores instead
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStore> CreateVectorStoreAsync(

            global::G.VectorStoreCreateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [DEPRECATED] Create a vector store<br/>
        /// DEPRECATED: Use POST /stores instead
        /// </summary>
        /// <param name="name">
        /// Name for the new vector store
        /// </param>
        /// <param name="description">
        /// Description of the vector store
        /// </param>
        /// <param name="isPublic">
        /// Whether the vector store can be accessed by anyone with valid login credentials<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expiresAfter">
        /// Optional expiration policy
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStore> CreateVectorStoreAsync(
            string? name = default,
            string? description = default,
            bool? isPublic = default,
            global::G.ExpiresAfter? expiresAfter = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}