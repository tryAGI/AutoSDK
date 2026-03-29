//HintName: G.ISnapshotsClient.RecoverShardFromSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Recover from a snapshot<br/>
        /// Recover shard of a local collection data from a snapshot. This will overwrite any data, stored in this shard, for the collection.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="wait"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RecoverShardFromSnapshotResponse> RecoverShardFromSnapshotAsync(
            string collectionName,
            int shardId,

            global::G.ShardSnapshotRecover request,
            bool? wait = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recover from a snapshot<br/>
        /// Recover shard of a local collection data from a snapshot. This will overwrite any data, stored in this shard, for the collection.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="wait"></param>
        /// <param name="location"></param>
        /// <param name="priority">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="checksum">
        /// Optional SHA256 checksum to verify snapshot integrity before recovery.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="apiKey">
        /// Optional API key used when fetching the snapshot from a remote URL.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RecoverShardFromSnapshotResponse> RecoverShardFromSnapshotAsync(
            string collectionName,
            int shardId,
            global::G.ShardSnapshotLocation location,
            bool? wait = default,
            global::G.SnapshotPriority? priority = default,
            string? checksum = default,
            string? apiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}