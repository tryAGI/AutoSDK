//HintName: G.Models.DiscoverRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use context and a target to find the most similar points, constrained by the context.
    /// </summary>
    public sealed partial class DiscoverRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Look for vectors closest to this.<br/>
        /// When using the target (with or without context), the integer part of the score represents the rank with respect to the context, while the decimal part of the score relates to the distance to the target.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public global::G.RecommendExample? Target { get; set; }

        /// <summary>
        /// Pairs of { positive, negative } examples to constrain the search.<br/>
        /// When using only the context (without a target), a special search - called context search - is performed where pairs of points are used to generate a loss that guides the search towards the zone where most positive examples overlap. This means that the score minimizes the scenario of finding a point closer to a negative than to a positive part of a pair.<br/>
        /// Since the score of a context relates to loss, the maximum score a point can get is 0.0, and it becomes normal that many points can have a score of 0.0.<br/>
        /// For discovery search (when including a target), the context part of the score for each pair is calculated +1 if the point is closer to a positive than to a negative part of a pair, and -1 otherwise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public global::System.Collections.Generic.IList<global::G.ContextExamplePair>? Context { get; set; }

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
        /// Max number of result to return
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// Offset of the first result to return. May be used to paginate results. Note: large offset values may cause performance issues.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Select which payload to return with the response. Default is false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_payload")]
        public global::G.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// Options for specifying which vectors to include into response. Default is false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_vector")]
        public global::G.WithVector? WithVector { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Max number of result to return
        /// </param>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="target">
        /// Look for vectors closest to this.<br/>
        /// When using the target (with or without context), the integer part of the score represents the rank with respect to the context, while the decimal part of the score relates to the distance to the target.
        /// </param>
        /// <param name="context">
        /// Pairs of { positive, negative } examples to constrain the search.<br/>
        /// When using only the context (without a target), a special search - called context search - is performed where pairs of points are used to generate a loss that guides the search towards the zone where most positive examples overlap. This means that the score minimizes the scenario of finding a point closer to a negative than to a positive part of a pair.<br/>
        /// Since the score of a context relates to loss, the maximum score a point can get is 0.0, and it becomes normal that many points can have a score of 0.0.<br/>
        /// For discovery search (when including a target), the context part of the score for each pair is calculated +1 if the point is closer to a positive than to a negative part of a pair, and -1 otherwise.
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
        /// Options for specifying which vectors to include into response. Default is false.
        /// </param>
        /// <param name="using">
        /// Define which vector to use for recommendation, if not specified - try to use default vector<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lookupFrom">
        /// The location used to lookup vectors. If not specified - use current collection. Note: the other collection should have the same vector size as the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public DiscoverRequest(
            int limit,
            global::G.ShardKeySelector? shardKey,
            global::G.RecommendExample? target,
            global::System.Collections.Generic.IList<global::G.ContextExamplePair>? context,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            int? offset,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            global::G.UsingVector? @using,
            global::G.LookupLocation? lookupFrom)
        {
            this.ShardKey = shardKey;
            this.Target = target;
            this.Context = context;
            this.Filter = filter;
            this.Params = @params;
            this.Limit = limit;
            this.Offset = offset;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
            this.Using = @using;
            this.LookupFrom = lookupFrom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverRequest" /> class.
        /// </summary>
        public DiscoverRequest()
        {
        }
    }
}