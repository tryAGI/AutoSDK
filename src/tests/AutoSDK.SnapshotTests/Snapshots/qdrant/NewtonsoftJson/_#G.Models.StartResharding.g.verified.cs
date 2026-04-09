//HintName: G.Models.StartResharding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartResharding
    {
        /// <summary>
        /// Resharding direction, scale up or down in number of shards<br/>
        /// - `up` - Scale up, add a new shard<br/>
        /// - `down` - Scale down, remove a shard
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direction", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReshardingDirectionJsonConverter))]
        public global::G.ReshardingDirection Direction { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_id")]
        public int? PeerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKey? ShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartResharding" /> class.
        /// </summary>
        /// <param name="direction">
        /// Resharding direction, scale up or down in number of shards<br/>
        /// - `up` - Scale up, add a new shard<br/>
        /// - `down` - Scale down, remove a shard
        /// </param>
        /// <param name="peerId"></param>
        /// <param name="shardKey"></param>
        public StartResharding(
            global::G.ReshardingDirection direction,
            int? peerId,
            global::G.ShardKey? shardKey)
        {
            this.Direction = direction;
            this.PeerId = peerId;
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartResharding" /> class.
        /// </summary>
        public StartResharding()
        {
        }
    }
}