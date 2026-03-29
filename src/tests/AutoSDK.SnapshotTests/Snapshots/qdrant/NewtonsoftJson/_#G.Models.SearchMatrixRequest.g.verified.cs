//HintName: G.Models.SearchMatrixRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchMatrixRequest
    {
        /// <summary>
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Look only for points which satisfies this conditions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// How many points to select and search within. Default is 10.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample")]
        public int? Sample { get; set; }

        /// <summary>
        /// How many neighbours per sample to find. Default is 3.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("using")]
        public string? Using { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixRequest" /> class.
        /// </summary>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions
        /// </param>
        /// <param name="sample">
        /// How many points to select and search within. Default is 10.
        /// </param>
        /// <param name="limit">
        /// How many neighbours per sample to find. Default is 3.
        /// </param>
        /// <param name="using">
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </param>
        public SearchMatrixRequest(
            global::G.ShardKeySelector? shardKey,
            global::G.Filter? filter,
            int? sample,
            int? limit,
            string? @using)
        {
            this.ShardKey = shardKey;
            this.Filter = filter;
            this.Sample = sample;
            this.Limit = limit;
            this.Using = @using;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixRequest" /> class.
        /// </summary>
        public SearchMatrixRequest()
        {
        }
    }
}