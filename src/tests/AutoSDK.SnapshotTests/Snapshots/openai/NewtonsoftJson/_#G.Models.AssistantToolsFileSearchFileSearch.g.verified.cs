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
        /// Note that the file search tool may output fewer than `max_num_results` results. See the [file search tool documentation](/docs/assistants/tools/file-search/number-of-chunks-returned) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_num_results")]
        public int? MaxNumResults { get; set; }

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
        /// Note that the file search tool may output fewer than `max_num_results` results. See the [file search tool documentation](/docs/assistants/tools/file-search/number-of-chunks-returned) for more information.
        /// </param>
        public AssistantToolsFileSearchFileSearch(
            int? maxNumResults)
        {
            this.MaxNumResults = maxNumResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearchFileSearch" /> class.
        /// </summary>
        public AssistantToolsFileSearchFileSearch()
        {
        }
    }
}