//HintName: G.Models.RemoteShardInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoteShardInfo
    {
        /// <summary>
        /// Remote shard id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ShardId { get; set; }

        /// <summary>
        /// User-defined sharding key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKey? ShardKey { get; set; }

        /// <summary>
        /// Remote peer id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeerId { get; set; }

        /// <summary>
        /// State of the single shard within a replica set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReplicaStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReplicaState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteShardInfo" /> class.
        /// </summary>
        /// <param name="shardId">
        /// Remote shard id
        /// </param>
        /// <param name="peerId">
        /// Remote peer id
        /// </param>
        /// <param name="state">
        /// State of the single shard within a replica set.
        /// </param>
        /// <param name="shardKey">
        /// User-defined sharding key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoteShardInfo(
            int shardId,
            int peerId,
            global::G.ReplicaState state,
            global::G.ShardKey? shardKey)
        {
            this.ShardId = shardId;
            this.ShardKey = shardKey;
            this.PeerId = peerId;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteShardInfo" /> class.
        /// </summary>
        public RemoteShardInfo()
        {
        }
    }
}