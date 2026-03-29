//HintName: G.Models.SearchGroupsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchGroupsRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Vector data separator for named and unnamed modes Unnamed mode:<br/>
        /// { "vector": [1.0, 2.0, 3.0] }<br/>
        /// or named mode:<br/>
        /// { "vector": { "vector": [1.0, 2.0, 3.0], "name": "image-embeddings" } }
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NamedVectorStructJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NamedVectorStruct Vector { get; set; }

        /// <summary>
        /// Look only for points which satisfies this conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// Additional search params
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public global::G.SearchParams? Params { get; set; }

        /// <summary>
        /// Select which payload to return with the response. Default is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_payload")]
        public global::G.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// Options for specifying which vectors to include into response. Default is false.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_vector")]
        public global::G.WithVector? WithVector { get; set; }

        /// <summary>
        /// Define a minimal score threshold for the result. If defined, less similar results will not be returned. Score of the returned result might be higher or smaller than the threshold depending on the Distance function used. E.g. for cosine similarity only higher scores will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupBy { get; set; }

        /// <summary>
        /// Maximum amount of points to return per group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GroupSize { get; set; }

        /// <summary>
        /// Maximum amount of groups to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Look for points in another collection using the group ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("with_lookup")]
        public global::G.WithLookupInterface? WithLookup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchGroupsRequest" /> class.
        /// </summary>
        /// <param name="vector">
        /// Vector data separator for named and unnamed modes Unnamed mode:<br/>
        /// { "vector": [1.0, 2.0, 3.0] }<br/>
        /// or named mode:<br/>
        /// { "vector": { "vector": [1.0, 2.0, 3.0], "name": "image-embeddings" } }
        /// </param>
        /// <param name="groupBy">
        /// Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.
        /// </param>
        /// <param name="groupSize">
        /// Maximum amount of points to return per group
        /// </param>
        /// <param name="limit">
        /// Maximum amount of groups to return
        /// </param>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions
        /// </param>
        /// <param name="params">
        /// Additional search params
        /// </param>
        /// <param name="withPayload">
        /// Select which payload to return with the response. Default is false.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vectors to include into response. Default is false.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scoreThreshold">
        /// Define a minimal score threshold for the result. If defined, less similar results will not be returned. Score of the returned result might be higher or smaller than the threshold depending on the Distance function used. E.g. for cosine similarity only higher scores will be returned.
        /// </param>
        /// <param name="withLookup">
        /// Look for points in another collection using the group ids
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchGroupsRequest(
            global::G.NamedVectorStruct vector,
            string groupBy,
            int groupSize,
            int limit,
            global::G.ShardKeySelector? shardKey,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            float? scoreThreshold,
            global::G.WithLookupInterface? withLookup)
        {
            this.ShardKey = shardKey;
            this.Vector = vector;
            this.Filter = filter;
            this.Params = @params;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
            this.ScoreThreshold = scoreThreshold;
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.GroupSize = groupSize;
            this.Limit = limit;
            this.WithLookup = withLookup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchGroupsRequest" /> class.
        /// </summary>
        public SearchGroupsRequest()
        {
        }
    }
}