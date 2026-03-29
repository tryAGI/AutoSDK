//HintName: G.ICollectionsClient.PutCollectionsByCollectionId.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Update collection<br/>
        /// Updates a collection's details
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutCollectionsByCollectionIdAsync(
            string collectionId,

            global::G.PutCollectionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update collection<br/>
        /// Updates a collection's details
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="name">
        /// New name for the collection
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutCollectionsByCollectionIdAsync(
            string collectionId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}