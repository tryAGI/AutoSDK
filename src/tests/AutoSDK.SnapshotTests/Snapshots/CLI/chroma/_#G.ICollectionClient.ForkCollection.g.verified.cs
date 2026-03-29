//HintName: G.ICollectionClient.ForkCollection.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionClient
    {
        /// <summary>
        /// Fork collection<br/>
        /// Creates a fork of an existing collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// const forked = await collection.fork({ name: 'forked_collection' });
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.Collection> ForkCollectionAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.ForkCollectionPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork collection<br/>
        /// Creates a fork of an existing collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="newName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Collection> ForkCollectionAsync(
            string tenant,
            string database,
            string collectionId,
            string newName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}