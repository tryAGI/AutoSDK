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
        /// The type of tool being defined: `file_search`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AssistantToolsFileSearchType Type { get; set; }

        /// <summary>
        /// Overrides for the file search tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_search")]
        public global::G.AssistantToolsFileSearchFileSearch? FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearch" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool being defined: `file_search`
        /// </param>
        /// <param name="fileSearch">
        /// Overrides for the file search tool.
        /// </param>
        public AssistantToolsFileSearch(
            global::G.AssistantToolsFileSearchType type,
            global::G.AssistantToolsFileSearchFileSearch? fileSearch)
        {
            this.Type = type;
            this.FileSearch = fileSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearch" /> class.
        /// </summary>
        public AssistantToolsFileSearch()
        {
        }
    }
}