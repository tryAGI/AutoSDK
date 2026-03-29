//HintName: G.Models.CollectionClusterInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current clustering distribution for the collection
    /// </summary>
    public sealed partial class CollectionClusterInfo
    {
        /// <summary>
        /// ID of this peer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeerId { get; set; }

        /// <summary>
        /// Total number of shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardCount { get; set; }

        /// <summary>
        /// Local shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("local_shards")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LocalShardInfo> LocalShards { get; set; }

        /// <summary>
        /// Remote shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_shards")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RemoteShardInfo> RemoteShards { get; set; }

        /// <summary>
        /// Shard transfers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_transfers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ShardTransferInfo> ShardTransfers { get; set; }

        /// <summary>
        /// Resharding operations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resharding_operations")]
        public global::System.Collections.Generic.IList<global::G.ReshardingInfo>? ReshardingOperations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionClusterInfo" /> class.
        /// </summary>
        /// <param name="peerId">
        /// ID of this peer
        /// </param>
        /// <param name="shardCount">
        /// Total number of shards
        /// </param>
        /// <param name="localShards">
        /// Local shards
        /// </param>
        /// <param name="remoteShards">
        /// Remote shards
        /// </param>
        /// <param name="shardTransfers">
        /// Shard transfers
        /// </param>
        /// <param name="reshardingOperations">
        /// Resharding operations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionClusterInfo(
            int peerId,
            int shardCount,
            global::System.Collections.Generic.IList<global::G.LocalShardInfo> localShards,
            global::System.Collections.Generic.IList<global::G.RemoteShardInfo> remoteShards,
            global::System.Collections.Generic.IList<global::G.ShardTransferInfo> shardTransfers,
            global::System.Collections.Generic.IList<global::G.ReshardingInfo>? reshardingOperations)
        {
            this.PeerId = peerId;
            this.ShardCount = shardCount;
            this.LocalShards = localShards ?? throw new global::System.ArgumentNullException(nameof(localShards));
            this.RemoteShards = remoteShards ?? throw new global::System.ArgumentNullException(nameof(remoteShards));
            this.ShardTransfers = shardTransfers ?? throw new global::System.ArgumentNullException(nameof(shardTransfers));
            this.ReshardingOperations = reshardingOperations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionClusterInfo" /> class.
        /// </summary>
        public CollectionClusterInfo()
        {
        }
    }
}