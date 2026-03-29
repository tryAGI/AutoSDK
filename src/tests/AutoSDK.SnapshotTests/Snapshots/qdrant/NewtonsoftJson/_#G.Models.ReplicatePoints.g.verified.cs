//HintName: G.Models.ReplicatePoints.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplicatePoints
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_shard_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardKey FromShardKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_shard_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ShardKey ToShardKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePoints" /> class.
        /// </summary>
        /// <param name="fromShardKey"></param>
        /// <param name="toShardKey"></param>
        /// <param name="filter"></param>
        public ReplicatePoints(
            global::G.ShardKey fromShardKey,
            global::G.ShardKey toShardKey,
            global::G.Filter? filter)
        {
            this.Filter = filter;
            this.FromShardKey = fromShardKey;
            this.ToShardKey = toShardKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePoints" /> class.
        /// </summary>
        public ReplicatePoints()
        {
        }
    }
}