//HintName: G.Models.ScoredPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search result
    /// </summary>
    public sealed partial class ScoredPoint
    {
        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtendedPointIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtendedPointId Id { get; set; }

        /// <summary>
        /// Point version<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Points vector distance to the query vector<br/>
        /// Example: 0.75F
        /// </summary>
        /// <example>0.75F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// Payload - values assigned to the point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public global::G.Payload? Payload { get; set; }

        /// <summary>
        /// Vector of the point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        public global::G.VectorStructOutput? Vector { get; set; }

        /// <summary>
        /// Shard Key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKey? ShardKey { get; set; }

        /// <summary>
        /// Order-by value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_value")]
        public global::G.OrderValue? OrderValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredPoint" /> class.
        /// </summary>
        /// <param name="id">
        /// Type, used for specifying point ID in user interface
        /// </param>
        /// <param name="version">
        /// Point version<br/>
        /// Example: 3
        /// </param>
        /// <param name="score">
        /// Points vector distance to the query vector<br/>
        /// Example: 0.75F
        /// </param>
        /// <param name="payload">
        /// Payload - values assigned to the point
        /// </param>
        /// <param name="vector">
        /// Vector of the point
        /// </param>
        /// <param name="shardKey">
        /// Shard Key
        /// </param>
        /// <param name="orderValue">
        /// Order-by value
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoredPoint(
            global::G.ExtendedPointId id,
            int version,
            float score,
            global::G.Payload? payload,
            global::G.VectorStructOutput? vector,
            global::G.ShardKey? shardKey,
            global::G.OrderValue? orderValue)
        {
            this.Id = id;
            this.Version = version;
            this.Score = score;
            this.Payload = payload;
            this.Vector = vector;
            this.ShardKey = shardKey;
            this.OrderValue = orderValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredPoint" /> class.
        /// </summary>
        public ScoredPoint()
        {
        }
    }
}