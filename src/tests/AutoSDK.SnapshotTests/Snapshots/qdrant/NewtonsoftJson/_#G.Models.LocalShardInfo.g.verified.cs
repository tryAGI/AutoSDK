//HintName: G.Models.LocalShardInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalShardInfo
    {
        /// <summary>
        /// Local shard id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardId { get; set; } = default!;

        /// <summary>
        /// User-defined sharding key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKey? ShardKey { get; set; }

        /// <summary>
        /// Number of points in the shard
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PointsCount { get; set; } = default!;

        /// <summary>
        /// State of the single shard within a replica set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReplicaState State { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShardInfo" /> class.
        /// </summary>
        /// <param name="shardId">
        /// Local shard id
        /// </param>
        /// <param name="pointsCount">
        /// Number of points in the shard
        /// </param>
        /// <param name="state">
        /// State of the single shard within a replica set.
        /// </param>
        /// <param name="shardKey">
        /// User-defined sharding key
        /// </param>
        public LocalShardInfo(
            int shardId,
            int pointsCount,
            global::G.ReplicaState state,
            global::G.ShardKey? shardKey)
        {
            this.ShardId = shardId;
            this.ShardKey = shardKey;
            this.PointsCount = pointsCount;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalShardInfo" /> class.
        /// </summary>
        public LocalShardInfo()
        {
        }
    }
}