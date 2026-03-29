//HintName: G.Models.ScrollRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Scroll request - paginate over all points which matches given condition
    /// </summary>
    public sealed partial class ScrollRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Start ID to read points from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public global::G.ExtendedPointId? Offset { get; set; }

        /// <summary>
        /// Page size. Default: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Look only for points which satisfies this conditions. If not provided - all points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// Select which payload to return with the response. Default is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_payload")]
        public global::G.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// Options for specifying which vector to include
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WithVectorJsonConverter))]
        public global::G.WithVector? WithVector { get; set; }

        /// <summary>
        /// Order the records by a payload field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public global::G.OrderByInterface? OrderBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollRequest" /> class.
        /// </summary>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="offset">
        /// Start ID to read points from.
        /// </param>
        /// <param name="limit">
        /// Page size. Default: 10
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions. If not provided - all points.
        /// </param>
        /// <param name="withPayload">
        /// Select which payload to return with the response. Default is true.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vector to include
        /// </param>
        /// <param name="orderBy">
        /// Order the records by a payload field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrollRequest(
            global::G.ShardKeySelector? shardKey,
            global::G.ExtendedPointId? offset,
            int? limit,
            global::G.Filter? filter,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            global::G.OrderByInterface? orderBy)
        {
            this.ShardKey = shardKey;
            this.Offset = offset;
            this.Limit = limit;
            this.Filter = filter;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
            this.OrderBy = orderBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollRequest" /> class.
        /// </summary>
        public ScrollRequest()
        {
        }
    }
}