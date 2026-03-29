//HintName: G.Models.CreateShardingKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateShardingKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardKey ShardKey { get; set; } = default!;

        /// <summary>
        /// How many shards to create for this key If not specified, will use the default value from config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shards_number")]
        public int? ShardsNumber { get; set; }

        /// <summary>
        /// How many replicas to create for each shard If not specified, will use the default value from config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replication_factor")]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// Placement of shards for this key List of peer ids, that can be used to place shards for this key If not specified, will be randomly placed among all peers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("placement")]
        public global::System.Collections.Generic.IList<int>? Placement { get; set; }

        /// <summary>
        /// Initial state of the shards for this key If not specified, will be `Initializing` first and then `Active` Warning: do not change this unless you know what you are doing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initial_state")]
        public global::G.ReplicaState? InitialState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardingKey" /> class.
        /// </summary>
        /// <param name="shardKey"></param>
        /// <param name="shardsNumber">
        /// How many shards to create for this key If not specified, will use the default value from config
        /// </param>
        /// <param name="replicationFactor">
        /// How many replicas to create for each shard If not specified, will use the default value from config
        /// </param>
        /// <param name="placement">
        /// Placement of shards for this key List of peer ids, that can be used to place shards for this key If not specified, will be randomly placed among all peers
        /// </param>
        /// <param name="initialState">
        /// Initial state of the shards for this key If not specified, will be `Initializing` first and then `Active` Warning: do not change this unless you know what you are doing
        /// </param>
        public CreateShardingKey(
            global::G.ShardKey shardKey,
            int? shardsNumber,
            int? replicationFactor,
            global::System.Collections.Generic.IList<int>? placement,
            global::G.ReplicaState? initialState)
        {
            this.ShardKey = shardKey;
            this.ShardsNumber = shardsNumber;
            this.ReplicationFactor = replicationFactor;
            this.Placement = placement;
            this.InitialState = initialState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShardingKey" /> class.
        /// </summary>
        public CreateShardingKey()
        {
        }
    }
}