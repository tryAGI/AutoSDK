//HintName: G.Models.CountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Count Request Counts the number of points which satisfy the given filter. If filter is not provided, the count of all points in the collection will be returned.
    /// </summary>
    public sealed partial class CountRequest
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
        /// If true, count exact number of points. If false, count approximate number of points faster. Approximate count might be unreliable during the indexing process. Default: true<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exact")]
        public bool? Exact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountRequest" /> class.
        /// </summary>
        /// <param name="shardKey">
        /// Specify in which shards to look for the points, if not specified - look in all shards
        /// </param>
        /// <param name="filter">
        /// Look only for points which satisfies this conditions
        /// </param>
        /// <param name="exact">
        /// If true, count exact number of points. If false, count approximate number of points faster. Approximate count might be unreliable during the indexing process. Default: true<br/>
        /// Default Value: true
        /// </param>
        public CountRequest(
            global::G.ShardKeySelector? shardKey,
            global::G.Filter? filter,
            bool? exact)
        {
            this.ShardKey = shardKey;
            this.Filter = filter;
            this.Exact = exact;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountRequest" /> class.
        /// </summary>
        public CountRequest()
        {
        }
    }
}