//HintName: G.ISnapshotsClient.RecoverShardFromUploadedSnapshot.g.cs
#nullable enable

namespace G
{
    public partial interface ISnapshotsClient
    {
        /// <summary>
        /// Recover shard from an uploaded snapshot<br/>
        /// Recover shard of a local collection from an uploaded snapshot. This will overwrite any data, stored on this node, for the collection shard.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="wait"></param>
        /// <param name="priority">
        /// Defines source of truth for snapshot recovery:<br/>
        /// `NoSync` means - restore snapshot without *any* additional synchronization. `Snapshot` means - prefer snapshot data over the current state. `Replica` means - prefer existing data over the snapshot.
        /// </param>
        /// <param name="checksum"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RecoverShardFromUploadedSnapshotResponse> RecoverShardFromUploadedSnapshotAsync(
            string collectionName,
            int shardId,

            global::G.RecoverShardFromUploadedSnapshotRequest request,
            bool? wait = default,
            global::G.SnapshotPriority? priority = default,
            string? checksum = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recover shard from an uploaded snapshot<br/>
        /// Recover shard of a local collection from an uploaded snapshot. This will overwrite any data, stored on this node, for the collection shard.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="shardId"></param>
        /// <param name="wait"></param>
        /// <param name="priority">
        /// Defines source of truth for snapshot recovery:<br/>
        /// `NoSync` means - restore snapshot without *any* additional synchronization. `Snapshot` means - prefer snapshot data over the current state. `Replica` means - prefer existing data over the snapshot.
        /// </param>
        /// <param name="checksum"></param>
        /// <param name="snapshot"></param>
        /// <param name="snapshotname"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RecoverShardFromUploadedSnapshotResponse> RecoverShardFromUploadedSnapshotAsync(
            string collectionName,
            int shardId,
            bool? wait = default,
            global::G.SnapshotPriority? priority = default,
            string? checksum = default,
            byte[]? snapshot = default,
            string? snapshotname = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}