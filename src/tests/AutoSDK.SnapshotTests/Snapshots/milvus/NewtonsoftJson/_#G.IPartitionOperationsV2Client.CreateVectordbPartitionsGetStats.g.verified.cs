//HintName: G.IPartitionOperationsV2Client.CreateVectordbPartitionsGetStats.g.cs
#nullable enable

namespace G
{
    public partial interface IPartitionOperationsV2Client
    {
        /// <summary>
        /// Get Partition Statistics<br/>
        /// This operations gets the number of entities in a partition.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbPartitionsGetStatsAsync(

            global::G.CreateVectordbPartitionsGetStatsRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Partition Statistics<br/>
        /// This operations gets the number of entities in a partition.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of an existing database. The value defaults to __default__.
        /// </param>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
        /// <param name="partitionName">
        /// The name of the target partition of this operation. 
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbPartitionsGetStatsAsync(
            string collectionName,
            string partitionName,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}