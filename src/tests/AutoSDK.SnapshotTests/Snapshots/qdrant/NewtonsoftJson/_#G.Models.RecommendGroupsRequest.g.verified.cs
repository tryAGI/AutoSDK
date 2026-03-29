//HintName: G.Models.RecommendGroupsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendGroupsRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Look for vectors closest to those<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("positive")]
        public global::System.Collections.Generic.IList<global::G.RecommendExample>? Positive { get; set; }

        /// <summary>
        /// Try to avoid vectors like this<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative")]
        public global::System.Collections.Generic.IList<global::G.RecommendExample>? Negative { get; set; }

        /// <summary>
        /// How to use positive and negative examples to find the results<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy")]
        public global::G.RecommendStrategy? Strategy { get; set; }

        /// <summary>
        /// Look only for points which satisfies this conditions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// Additional search params
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public global::G.SearchParams? Params { get; set; }

        /// <summary>
        /// Select which payload to return with the response. Default is false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_payload")]
        public global::G.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// Options for specifying which vectors to include into response. Default is false.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_vector")]
        public global::G.WithVector? WithVector { get; set; }

        /// <summary>
        /// Define a minimal score threshold for the result. If defined, less similar results will not be returned. Score of the returned result might be higher or smaller than the threshold depending on the Distance function used. E.g. for cosine similarity only higher scores will be returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_threshold")]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// Define which vector to use for recommendation, if not specified - try to use default vector<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("using")]
        public global::G.UsingVector? Using { get; set; }

        /// <summary>
        /// The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lookup_from")]
        public global::G.LookupLocation? LookupFrom { get; set; }

        /// <summary>
        /// Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string GroupBy { get; set; } = default!;

        /// <summary>
        /// Maximum amount of points to return per group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int GroupSize { get; set; } = default!;

        /// <summary>
        /// Maximum amount of groups to return
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// Look for points in another collection using the group ids
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_lookup")]
        public global::G.WithLookupInterface? WithLookup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendGroupsRequest" /> class.
        /// </summary>
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
        /// <param name="positive">
        /// Look for vectors closest to those<br/>
        /// Default Value: []
        /// </param>
        /// <param name="negative">
        /// Try to avoid vectors like this<br/>
        /// Default Value: []
        /// </param>
        /// <param name="strategy">
        /// How to use positive and negative examples to find the results<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// <param name="using">
        /// Define which vector to use for recommendation, if not specified - try to use default vector<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lookupFrom">
        /// The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="withLookup">
        /// Look for points in another collection using the group ids
        /// </param>
        public RecommendGroupsRequest(
            string groupBy,
            int groupSize,
            int limit,
            global::G.ShardKeySelector? shardKey,
            global::System.Collections.Generic.IList<global::G.RecommendExample>? positive,
            global::System.Collections.Generic.IList<global::G.RecommendExample>? negative,
            global::G.RecommendStrategy? strategy,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            float? scoreThreshold,
            global::G.UsingVector? @using,
            global::G.LookupLocation? lookupFrom,
            global::G.WithLookupInterface? withLookup)
        {
            this.ShardKey = shardKey;
            this.Positive = positive;
            this.Negative = negative;
            this.Strategy = strategy;
            this.Filter = filter;
            this.Params = @params;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
            this.ScoreThreshold = scoreThreshold;
            this.Using = @using;
            this.LookupFrom = lookupFrom;
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.GroupSize = groupSize;
            this.Limit = limit;
            this.WithLookup = withLookup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendGroupsRequest" /> class.
        /// </summary>
        public RecommendGroupsRequest()
        {
        }
    }
}