//HintName: G.Models.QueryGroupsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryGroupsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Sub-requests to perform first. If present, the query will be performed on the results of the prefetch(es).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefetch")]
        public global::G.AnyOf<global::G.Prefetch2, global::System.Collections.Generic.IList<global::G.Prefetch2>, object>? Prefetch { get; set; }

        /// <summary>
        /// Query to perform. If missing without prefetches, returns points ordered by their IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public global::G.QueryInterface? Query { get; set; }

        /// <summary>
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("using")]
        public string? Using { get; set; }

        /// <summary>
        /// Filter conditions - return only those points that satisfy the specified conditions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// Search params for when there is no prefetch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public global::G.SearchParams? Params { get; set; }

        /// <summary>
        /// Return points with scores better than this threshold.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_threshold")]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// Options for specifying which vectors to include into the response. Default is false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_vector")]
        public global::G.WithVector? WithVector { get; set; }

        /// <summary>
        /// Options for specifying which payload to include or not. Default is false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_payload")]
        public global::G.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// The location to use for IDs lookup, if not specified - use the current collection and the 'using' vector Note: the other collection vectors should have the same vector size as the 'using' vector in the current collection<br/>
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
        /// Maximum amount of points to return per group. Default is 3.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_size")]
        public int? GroupSize { get; set; }

        /// <summary>
        /// Maximum amount of groups to return. Default is 10.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

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
        /// Initializes a new instance of the <see cref="QueryGroupsRequest" /> class.
        /// </summary>
        /// <param name="groupBy">
        /// Payload field to group by, must be a string or number field. If the field contains more than 1 value, all values will be used for grouping. One point can be in multiple groups.
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="prefetch">
        /// Sub-requests to perform first. If present, the query will be performed on the results of the prefetch(es).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="query">
        /// Query to perform. If missing without prefetches, returns points ordered by their IDs.
        /// </param>
        /// <param name="using">
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </param>
        /// <param name="filter">
        /// Filter conditions - return only those points that satisfy the specified conditions.
        /// </param>
        /// <param name="params">
        /// Search params for when there is no prefetch
        /// </param>
        /// <param name="scoreThreshold">
        /// Return points with scores better than this threshold.
        /// </param>
        /// <param name="withVector">
        /// Options for specifying which vectors to include into the response. Default is false.
        /// </param>
        /// <param name="withPayload">
        /// Options for specifying which payload to include or not. Default is false.
        /// </param>
        /// <param name="lookupFrom">
        /// The location to use for IDs lookup, if not specified - use the current collection and the 'using' vector Note: the other collection vectors should have the same vector size as the 'using' vector in the current collection<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupSize">
        /// Maximum amount of points to return per group. Default is 3.
        /// </param>
        /// <param name="limit">
        /// Maximum amount of groups to return. Default is 10.
        /// </param>
        /// <param name="withLookup">
        /// Look for points in another collection using the group ids
        /// </param>
        public QueryGroupsRequest(
            string groupBy,
            global::G.ShardKeySelector? shardKey,
            global::G.AnyOf<global::G.Prefetch2, global::System.Collections.Generic.IList<global::G.Prefetch2>, object>? prefetch,
            global::G.QueryInterface? query,
            string? @using,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            float? scoreThreshold,
            global::G.WithVector? withVector,
            global::G.WithPayloadInterface? withPayload,
            global::G.LookupLocation? lookupFrom,
            int? groupSize,
            int? limit,
            global::G.WithLookupInterface? withLookup)
        {
            this.ShardKey = shardKey;
            this.Prefetch = prefetch;
            this.Query = query;
            this.Using = @using;
            this.Filter = filter;
            this.Params = @params;
            this.ScoreThreshold = scoreThreshold;
            this.WithVector = withVector;
            this.WithPayload = withPayload;
            this.LookupFrom = lookupFrom;
            this.GroupBy = groupBy ?? throw new global::System.ArgumentNullException(nameof(groupBy));
            this.GroupSize = groupSize;
            this.Limit = limit;
            this.WithLookup = withLookup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryGroupsRequest" /> class.
        /// </summary>
        public QueryGroupsRequest()
        {
        }
    }
}