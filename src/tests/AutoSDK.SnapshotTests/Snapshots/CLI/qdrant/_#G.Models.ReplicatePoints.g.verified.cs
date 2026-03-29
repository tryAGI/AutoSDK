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
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_shard_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShardKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ShardKey FromShardKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_shard_key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ShardKeyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ShardKey ToShardKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicatePoints" /> class.
        /// </summary>
        /// <param name="fromShardKey"></param>
        /// <param name="toShardKey"></param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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