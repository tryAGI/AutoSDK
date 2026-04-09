//HintName: G.ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient.DeleteAssets.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// Remove assets from an entity<br/>
        /// This method removes from the specified entity. Assets are used to identify the entity in media content, and removing assets may impact the accuracy of entity recognition in searches if too few assets remain.<br/>
        /// When assets are removed, the entity may temporarily enter a "processing" state while the system updates the necessary data. Once processing is complete, the entity status will return to "ready."<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        ///   - This operation only removes the association between the entity and the specified assets; it does not delete the assets themselves.<br/>
        ///   - An entity must always have at least one asset associated with it. You can't remove the last asset from an entity.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> DeleteAssetsAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,

            global::G.DeleteAssetsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove assets from an entity<br/>
        /// This method removes from the specified entity. Assets are used to identify the entity in media content, and removing assets may impact the accuracy of entity recognition in searches if too few assets remain.<br/>
        /// When assets are removed, the entity may temporarily enter a "processing" state while the system updates the necessary data. Once processing is complete, the entity status will return to "ready."<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        ///   - This operation only removes the association between the entity and the specified assets; it does not delete the assets themselves.<br/>
        ///   - An entity must always have at least one asset associated with it. You can't remove the last asset from an entity.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="entityId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="assetIds">
        /// An array of asset IDs to remove from the entity.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> DeleteAssetsAsync(
            string entityCollectionId,
            string entityId,
            string xApiKey,
            global::System.Collections.Generic.IList<string> assetIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}