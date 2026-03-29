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
        [global::Newtonsoft.Json.JsonProperty("peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PeerId { get; set; } = default!;

        /// <summary>
        /// Total number of shards
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardCount { get; set; } = default!;

        /// <summary>
        /// Local shards
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("local_shards", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LocalShardInfo> LocalShards { get; set; } = default!;

        /// <summary>
        /// Remote shards
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remote_shards", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RemoteShardInfo> RemoteShards { get; set; } = default!;

        /// <summary>
        /// Shard transfers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_transfers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ShardTransferInfo> ShardTransfers { get; set; } = default!;

        /// <summary>
        /// Resharding operations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resharding_operations")]
        public global::System.Collections.Generic.IList<global::G.ReshardingInfo>? ReshardingOperations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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