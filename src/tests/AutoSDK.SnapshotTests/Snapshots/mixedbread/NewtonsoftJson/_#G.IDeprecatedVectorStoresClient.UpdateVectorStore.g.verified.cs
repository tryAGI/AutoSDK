//HintName: G.IDeprecatedVectorStoresClient.UpdateVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Update a vector store<br/>
        /// DEPRECATED: Use PUT /stores/{store_identifier} instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStore> UpdateVectorStoreAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,

            global::G.VectorStoreUpdateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [DEPRECATED] Update a vector store<br/>
        /// DEPRECATED: Use PUT /stores/{store_identifier} instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="name">
        /// New name for the store
        /// </param>
        /// <param name="description">
        /// New description
        /// </param>
        /// <param name="isPublic">
        /// Whether the vector store can be accessed by anyone with valid login credentials
        /// </param>
        /// <param name="expiresAfter">
        /// Optional expiration policy
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStore> UpdateVectorStoreAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            string? name = default,
            string? description = default,
            bool? isPublic = default,
            global::G.ExpiresAfter? expiresAfter = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}