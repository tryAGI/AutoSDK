//HintName: G.ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// Delete an entity<br/>
        /// This method deletes a specific entity from an entity collection. It permanently removes the entity and its associated data, but does not affect the assets associated with this entity.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EntityCollectionsEntitiesDeleteResponse204> DeleteAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}