//HintName: G.ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient.CreateAssets.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// Add assets to an entity<br/>
        /// This method adds assets to the specified entity within an entity collection. Assets are used to identify the entity in media content, and adding multiple assets can improve the accuracy of entity recognition in searches.<br/>
        /// When assets are added, the entity may temporarily enter the "processing" state while the platform updates the necessary data. Once processing is complete, the entity status will return to "ready."
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> CreateAssetsAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,

            global::G.CreateAssetsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add assets to an entity<br/>
        /// This method adds assets to the specified entity within an entity collection. Assets are used to identify the entity in media content, and adding multiple assets can improve the accuracy of entity recognition in searches.<br/>
        /// When assets are added, the entity may temporarily enter the "processing" state while the platform updates the necessary data. Once processing is complete, the entity status will return to "ready."
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="assetIds">
        /// An array of asset IDs to add to the entity.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> CreateAssetsAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,
            global::System.Collections.Generic.IList<string> assetIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}