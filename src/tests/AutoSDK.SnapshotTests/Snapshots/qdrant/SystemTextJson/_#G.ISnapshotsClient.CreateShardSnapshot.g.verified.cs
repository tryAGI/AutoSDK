//HintName: G.ISnapshotsClient.CreateShardSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Create shard snapshot<br/>
        /// Create new snapshot of a shard for a collection
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="wait"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateShardSnapshotResponse> CreateShardSnapshotAsync(
            string collectionName,
            int shardId,
            bool? wait = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}