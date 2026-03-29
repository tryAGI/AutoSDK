//HintName: G.ICollectionOperationsV2Client.CreateVectordbCollectionsGetStats.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionOperationsV2Client
    {
        /// <summary>
        /// Get Collection Stats<br/>
        /// This operations gets the number of entities in a collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbCollectionsGetStatsAsync(

            global::G.GetStatsReq request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Collection Stats<br/>
        /// This operations gets the number of entities in a collection.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database which the collection belongs to. Setting this to a non-existing database results in an error.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to check.<br/>
        /// Setting this to a non-existing database results in an error.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbCollectionsGetStatsAsync(
            string dbName,
            string collectionName,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}