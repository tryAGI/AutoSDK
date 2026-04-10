//HintName: G.Models.ReRankConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReRankConfig
    {
        /// <summary>
        /// The number of nodes to retrieve after reranking over retrieved nodes from all retrieval tools.<br/>
        /// Default Value: 6
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// The type of reranker to use.<br/>
        /// Default Value: system_default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReRankerTypeJsonConverter))]
        public global::G.ReRankerType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReRankConfig" /> class.
        /// </summary>
        /// <param name="topN">
        /// The number of nodes to retrieve after reranking over retrieved nodes from all retrieval tools.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="type">
        /// The type of reranker to use.<br/>
        /// Default Value: system_default
        /// </param>
        public ReRankConfig(
            int? topN,
            global::G.ReRankerType? type)
        {
            this.TopN = topN;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReRankConfig" /> class.
        /// </summary>
        public ReRankConfig()
        {
        }
    }
}