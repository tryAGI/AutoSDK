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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssistantToolsFileSearchType Type { get; set; } = default!;

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
    }
}