//HintName: G.ICollectionClient.CountCollections.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Get number of collections<br/>
        /// Returns the total number of collections in a database.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const count: number = await client.countCollections();
        /// </remarks>
        global::System.Threading.Tasks.Task<int> CountCollectionsAsync(
            string tenant,
            string database,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}