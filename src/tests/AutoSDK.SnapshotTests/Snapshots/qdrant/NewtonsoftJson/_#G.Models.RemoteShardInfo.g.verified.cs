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
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardId { get; set; } = default!;

        /// <summary>
        /// User-defined sharding key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKey? ShardKey { get; set; }

        /// <summary>
        /// Remote peer id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PeerId { get; set; } = default!;

        /// <summary>
        /// State of the single shard within a replica set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReplicaStateJsonConverter))]
        public global::G.ReplicaState State { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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