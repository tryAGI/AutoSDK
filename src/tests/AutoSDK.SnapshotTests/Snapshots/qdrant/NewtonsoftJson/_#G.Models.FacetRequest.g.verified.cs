//HintName: G.Models.FacetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FacetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Payload key to use for faceting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Max number of hits to return. Default is 10.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Filter conditions - only consider points that satisfy these conditions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// Whether to do a more expensive exact count for each of the values in the facet. Default is false.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exact")]
        public bool? Exact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// Payload key to use for faceting.
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="limit">
        /// Max number of hits to return. Default is 10.
        /// </param>
        /// <param name="filter">
        /// Filter conditions - only consider points that satisfy these conditions.
        /// </param>
        /// <param name="exact">
        /// Whether to do a more expensive exact count for each of the values in the facet. Default is false.
        /// </param>
        public FacetRequest(
            string key,
            global::G.ShardKeySelector? shardKey,
            int? limit,
            global::G.Filter? filter,
            bool? exact)
        {
            this.ShardKey = shardKey;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Limit = limit;
            this.Filter = filter;
            this.Exact = exact;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetRequest" /> class.
        /// </summary>
        public FacetRequest()
        {
        }
    }
}