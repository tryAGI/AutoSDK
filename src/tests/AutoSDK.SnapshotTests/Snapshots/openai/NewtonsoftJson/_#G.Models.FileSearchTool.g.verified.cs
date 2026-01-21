//HintName: G.Models.FileSearchTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that searches for relevant content from uploaded files. Learn more about the [file search tool](https://platform.openai.com/docs/guides/tools-file-search).
    /// </summary>
    public sealed partial class FileSearchTool
    {
        /// <summary>
        /// The type of the file search tool. Always `file_search`.<br/>
        /// Default Value: file_search
        /// </summary>
        /// <default>global::G.FileSearchToolType.FileSearch</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FileSearchToolType Type { get; set; } = global::G.FileSearchToolType.FileSearch;

        /// <summary>
        /// The IDs of the vector stores to search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> VectorStoreIds { get; set; } = default!;

        /// <summary>
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranking_options")]
        public global::G.RankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.Filters2? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the file search tool. Always `file_search`.<br/>
        /// Default Value: file_search
        /// </param>
        /// <param name="vectorStoreIds">
        /// The IDs of the vector stores to search.
        /// </param>
        /// <param name="maxNumResults">
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.
        /// </param>
        /// <param name="rankingOptions"></param>
        /// <param name="filters"></param>
        public FileSearchTool(
            global::System.Collections.Generic.IList<string> vectorStoreIds,
            int? maxNumResults,
            global::G.RankingOptions? rankingOptions,
            global::G.Filters2? filters,
            global::G.FileSearchToolType type = global::G.FileSearchToolType.FileSearch)
        {
            this.VectorStoreIds = vectorStoreIds ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIds));
            this.Type = type;
            this.MaxNumResults = maxNumResults;
            this.RankingOptions = rankingOptions;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchTool" /> class.
        /// </summary>
        public FileSearchTool()
        {
        }
    }
}