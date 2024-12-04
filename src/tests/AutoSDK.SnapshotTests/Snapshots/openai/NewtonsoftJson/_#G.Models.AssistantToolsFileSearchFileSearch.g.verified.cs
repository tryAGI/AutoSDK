//HintName: G.Models.AssistantToolsFileSearchFileSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Overrides for the file search tool.
    /// </summary>
    public sealed partial class AssistantToolsFileSearchFileSearch
    {
        /// <summary>
        /// The maximum number of results the file search tool should output. The default is 20 for `gpt-4*` models and 5 for `gpt-3.5-turbo`. This number should be between 1 and 50 inclusive.<br/>
        /// Note that the file search tool may output fewer than `max_num_results` results. See the [file search tool documentation](/docs/assistants/tools/file-search#customizing-file-search-settings) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_num_results")]
        public int? MaxNumResults { get; set; }

        /// <summary>
        /// The ranking options for the file search. If not specified, the file search tool will use the `auto` ranker and a score_threshold of 0.<br/>
        /// See the [file search tool documentation](/docs/assistants/tools/file-search#customizing-file-search-settings) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranking_options")]
        public global::G.FileSearchRankingOptions? RankingOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearchFileSearch" /> class.
        /// </summary>
        /// <param name="maxNumResults">
        /// The maximum number of results the file search tool should output. The default is 20 for `gpt-4*` models and 5 for `gpt-3.5-turbo`. This number should be between 1 and 50 inclusive.<br/>
        /// Note that the file search tool may output fewer than `max_num_results` results. See the [file search tool documentation](/docs/assistants/tools/file-search#customizing-file-search-settings) for more information.
        /// </param>
        /// <param name="rankingOptions">
        /// The ranking options for the file search. If not specified, the file search tool will use the `auto` ranker and a score_threshold of 0.<br/>
        /// See the [file search tool documentation](/docs/assistants/tools/file-search#customizing-file-search-settings) for more information.
        /// </param>
        public AssistantToolsFileSearchFileSearch(
            int? maxNumResults,
            global::G.FileSearchRankingOptions? rankingOptions)
        {
            this.MaxNumResults = maxNumResults;
            this.RankingOptions = rankingOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearchFileSearch" /> class.
        /// </summary>
        public AssistantToolsFileSearchFileSearch()
        {
        }
    }
}