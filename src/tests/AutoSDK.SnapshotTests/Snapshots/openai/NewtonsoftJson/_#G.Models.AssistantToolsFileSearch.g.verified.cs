//HintName: G.Models.AssistantToolsFileSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantToolsFileSearch
    {
        /// <summary>
        /// Overrides for the file search tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_search")]
        public global::G.AssistantToolsFileSearchFileSearch? FileSearch { get; set; }

        /// <summary>
        /// The type of tool being defined: `file_search`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AssistantToolsFileSearchType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearch" /> class.
        /// </summary>
        /// <param name="fileSearch">
        /// Overrides for the file search tool.
        /// </param>
        /// <param name="type">
        /// The type of tool being defined: `file_search`
        /// </param>
        public AssistantToolsFileSearch(
            global::G.AssistantToolsFileSearchFileSearch? fileSearch,
            global::G.AssistantToolsFileSearchType type)
        {
            this.FileSearch = fileSearch;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearch" /> class.
        /// </summary>
        public AssistantToolsFileSearch()
        {
        }
    }
}