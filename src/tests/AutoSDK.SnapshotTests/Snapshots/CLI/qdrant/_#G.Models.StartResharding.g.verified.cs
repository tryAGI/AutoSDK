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
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReshardingDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReshardingDirection Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peer_id")]
        public int? PeerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKey? ShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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