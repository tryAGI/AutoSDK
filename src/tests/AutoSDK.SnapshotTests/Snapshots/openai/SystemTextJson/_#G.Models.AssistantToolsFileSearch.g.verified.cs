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
        [global::System.Text.Json.Serialization.JsonPropertyName("file_search")]
        public global::G.AssistantToolsFileSearchFileSearch? FileSearch { get; set; }

        /// <summary>
        /// The type of tool being defined: `file_search`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantToolsFileSearchTypeJsonConverter))]
        public global::G.AssistantToolsFileSearchType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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