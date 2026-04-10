//HintName: G.Models.FileSearchServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File search tool configuration
    /// </summary>
    public sealed partial class FileSearchServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FileSearchServerToolTypeJsonConverter))]
        public global::G.FileSearchServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> VectorStoreIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.FileSearchServerToolFilters? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranking_options")]
        public global::G.FileSearchServerToolRankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchServerTool" /> class.
        /// </summary>
        /// <param name="vectorStoreIds"></param>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        /// <param name="maxNumResults"></param>
        /// <param name="rankingOptions"></param>
        public FileSearchServerTool(
            global::System.Collections.Generic.IList<string> vectorStoreIds,
            global::G.FileSearchServerToolType type,
            global::G.FileSearchServerToolFilters? filters,
            int? maxNumResults,
            global::G.FileSearchServerToolRankingOptions? rankingOptions)
        {
            this.Type = type;
            this.VectorStoreIds = vectorStoreIds ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIds));
            this.Filters = filters;
            this.MaxNumResults = maxNumResults;
            this.RankingOptions = rankingOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchServerTool" /> class.
        /// </summary>
        public FileSearchServerTool()
        {
        }
    }
}