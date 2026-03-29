//HintName: G.Models.SearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search request. Holds all conditions and parameters for the search of most similar points by vector similarity given the filtering restrictions.
    /// </summary>
    public sealed partial class SearchRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Vector data separator for named and unnamed modes Unnamed mode:<br/>
        /// { "vector": [1.0, 2.0, 3.0] }<br/>
        /// or named mode:<br/>
        /// { "vector": { "vector": [1.0, 2.0, 3.0], "name": "image-embeddings" } }
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NamedVectorStruct Vector { get; set; } = default!;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="vector">
        /// Vector data separator for named and unnamed modes Unnamed mode:<br/>
        /// { "vector": [1.0, 2.0, 3.0] }<br/>
        /// or named mode:<br/>
        /// { "vector": { "vector": [1.0, 2.0, 3.0], "name": "image-embeddings" } }
        /// </param>
        /// <param name="limit">
        /// Max number of result to return
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
        public SearchRequest(
            global::G.NamedVectorStruct vector,
            int limit,
            global::G.ShardKeySelector? shardKey,
            global::G.Filter? filter,
            global::G.SearchParams? @params,
            int? offset,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVector,
            float? scoreThreshold)
        {
            this.ShardKey = shardKey;
            this.Vector = vector;
            this.Filter = filter;
            this.Params = @params;
            this.Limit = limit;
            this.Offset = offset;
            this.WithPayload = withPayload;
            this.WithVector = withVector;
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }
    }
}