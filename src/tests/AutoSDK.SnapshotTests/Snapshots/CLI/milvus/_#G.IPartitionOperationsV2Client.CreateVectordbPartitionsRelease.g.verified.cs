//HintName: G.IPartitionOperationsV2Client.CreateVectordbPartitionsRelease.g.cs
#nullable enable

namespace G
{
    public partial interface IPartitionOperationsV2Client
    {
        /// <summary>
        /// Release Partitions<br/>
        /// This operation releases the data of the current partition from memory.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbPartitionsReleaseAsync(

            global::G.PartitionNames request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Release Partitions<br/>
        /// This operation releases the data of the current partition from memory.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="partitionNames1">
        /// The list of names of the target partitions.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbPartitionsReleaseAsync(
            string collectionName,
            global::System.Collections.Generic.IList<string> partitionNames1,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}