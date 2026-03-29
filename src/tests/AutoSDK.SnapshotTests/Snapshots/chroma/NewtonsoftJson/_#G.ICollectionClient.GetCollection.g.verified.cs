//HintName: G.ICollectionClient.GetCollection.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Get collection<br/>
        /// Returns a collection by ID or name.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const collection = await client.getCollection({ name: 'my_collection' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Collection> GetCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}