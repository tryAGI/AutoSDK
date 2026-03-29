//HintName: G.ICollectionsClient.CollectionExists.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Check the existence of a collection<br/>
        /// Returns "true" if the given collection name exists, and "false" otherwise
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CollectionExistsResponse> CollectionExistsAsync(
            string collectionName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}