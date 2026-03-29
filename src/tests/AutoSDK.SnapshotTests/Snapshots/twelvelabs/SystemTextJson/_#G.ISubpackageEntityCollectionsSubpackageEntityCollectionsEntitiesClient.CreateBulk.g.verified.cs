//HintName: G.ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient.CreateBulk.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// Create multiple entities in bulk<br/>
        /// This method creates multiple entities within a specified entity collection in a single request. Each entity must be associated with at least one asset. This endpoint is useful for efficiently adding multiple entities, such as a roster of players or a group of characters.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkCreateEntityResponse> CreateBulkAsync(
            string entityCollectionId,
            string xApiKey,

            global::G.CreateBulkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create multiple entities in bulk<br/>
        /// This method creates multiple entities within a specified entity collection in a single request. Each entity must be associated with at least one asset. This endpoint is useful for efficiently adding multiple entities, such as a roster of players or a group of characters.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="entities"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BulkCreateEntityResponse> CreateBulkAsync(
            string entityCollectionId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::G.EntityCollectionsEntityCollectionIdEntitiesBulkPostRequestBodyContentApplicationJsonSchemaEntitiesItems> entities,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}