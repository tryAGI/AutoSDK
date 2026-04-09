//HintName: G.ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// Update an entity<br/>
        /// This method updates the specified entity within an entity collection. This operation allows modification of the entity's name, description, or metadata. Note that this endpoint does not affect the assets associated with the entity.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> UpdateAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,

            global::G.UpdateRequest5 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an entity<br/>
        /// This method updates the specified entity within an entity collection. This operation allows modification of the entity's name, description, or metadata. Note that this endpoint does not affect the assets associated with the entity.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The new name for the entity.
        /// </param>
        /// <param name="description">
        /// An updated description for the entity.
        /// </param>
        /// <param name="metadata">
        /// Updated metadata for the entity. If provided, this completely replaces the existing metadata. Use this to store custom key-value pairs related to the entity.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> UpdateAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,
            string? name = default,
            string? description = default,
            global::G.EntityCollectionsEntityCollectionIdEntitiesEntityIdPatchRequestBodyContentApplicationJsonSchemaMetadata? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}