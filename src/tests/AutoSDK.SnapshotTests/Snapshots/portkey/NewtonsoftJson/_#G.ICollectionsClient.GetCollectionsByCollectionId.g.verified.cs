//HintName: G.ICollectionsClient.GetCollectionsByCollectionId.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Get collection details<br/>
        /// Retrieves details of a specific collection
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CollectionWithChildCollections> GetCollectionsByCollectionIdAsync(
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}