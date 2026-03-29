//HintName: G.Models.RecommendRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Recommendation request. Provides positive and negative examples of the vectors, which can be ids of points that are already stored in the collection, raw vectors, or even ids and vectors combined.<br/>
    /// Service should look for the points which are closer to positive examples and at the same time further to negative examples. The concrete way of how to compare negative and positive distances is up to the `strategy` chosen.
    /// </summary>
    public sealed partial class RecommendRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Look for vectors closest to those<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive")]
        public global::System.Collections.Generic.IList<global::G.RecommendExample>? Positive { get; set; }

        /// <summary>
        /// Try to avoid vectors like this<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative")]
        public global::System.Collections.Generic.IList<global::G.RecommendExample>? Negative { get; set; }

        /// <summary>
        /// How to use positive and negative examples to find the results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        public global::G.RecommendStrategy? Strategy { get; set; }

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
        /// Max number of result to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Offset of the first result to return. May be used to paginate results. Note: large offset values may cause performance issues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

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
        /// Define which vector to use for recommendation, if not specified - try to use default vector<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("using")]
        public global::G.UsingVector? Using { get; set; }

        /// <summary>
        /// The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lookup_from")]
        public global::G.LookupLocation? LookupFrom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Max number of result to return
        /// </param>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="positive">
        /// Look for vectors closest to those<br/>
        /// Default Value: []
        /// </param>
        /// <param name="negative">
        /// Try to avoid vectors like this<br/>
        /// Default Value: []
        /// </param>
        /// <param name="strategy">
        /// How to use positive and negative examples to find the results
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions
        /// </param>
        /// <param name="params">
        /// Additional search params
        /// </param>
        /// <param name="offset">
        /// Offset of the first result to return. May be used to paginate results. Note: large offset values may cause performance issues.
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
        /// <param name="using">
        /// Define which vector to use for recommendation, if not specified - try to use default vector<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lookupFrom">
        /// The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendRequest(
            int limit,
            global::G.ShardKeySelector? shardKey,
            global::System.Collections.Generic.IList<global::G.RecommendExample>? positive,
            global::System.Collections.Generic.IList<global::G.RecommendExample>? negative,
            global::G.RecommendStrategy? strategy,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            int? offset,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            float? scoreThreshold,
            global::G.UsingVector? @using,
            global::G.LookupLocation? lookupFrom)
        {
            this.ShardKey = shardKey;
            this.Positive = positive;
            this.Negative = negative;
            this.Strategy = strategy;
            this.Filter = filter;
            this.Params = @params;
            this.Limit = limit;
            this.Offset = offset;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
            this.ScoreThreshold = scoreThreshold;
            this.Using = @using;
            this.LookupFrom = lookupFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendRequest" /> class.
        /// </summary>
        public RecommendRequest()
        {
        }
    }
}