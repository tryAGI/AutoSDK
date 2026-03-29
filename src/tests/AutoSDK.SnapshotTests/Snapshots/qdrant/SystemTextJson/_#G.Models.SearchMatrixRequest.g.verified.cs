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
        [global::System.Text.Json.Serialization.JsonPropertyName("shard_key")]
        public global::G.ShardKeySelector? ShardKey { get; set; }

        /// <summary>
        /// Look only for points which satisfies this conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.Filter? Filter { get; set; }

        /// <summary>
        /// How many points to select and search within. Default is 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample")]
        public int? Sample { get; set; }

        /// <summary>
        /// How many neighbours per sample to find. Default is 3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Define which vector name to use for querying. If missing, the default vector is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("using")]
        public string? Using { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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