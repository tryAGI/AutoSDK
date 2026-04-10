//HintName: G.Models.ReshardingInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReshardingInfo
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
        [global::Newtonsoft.Json.JsonProperty("shard_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ShardId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peer_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int PeerId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ReshardingInfo" /> class.
        /// </summary>
        /// <param name="direction">
        /// Resharding direction, scale up or down in number of shards<br/>
        /// - `up` - Scale up, add a new shard<br/>
        /// - `down` - Scale down, remove a shard
        /// </param>
        /// <param name="shardId"></param>
        /// <param name="peerId"></param>
        /// <param name="shardKey"></param>
        public ReshardingInfo(
            global::G.ReshardingDirection direction,
            int shardId,
            int peerId,
            global::G.ShardKey? shardKey)
        {
            this.Direction = direction;
            this.ShardId = shardId;
            this.PeerId = peerId;
            this.ShardKey = shardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReshardingInfo" /> class.
        /// </summary>
        public ReshardingInfo()
        {
        }
    }
}