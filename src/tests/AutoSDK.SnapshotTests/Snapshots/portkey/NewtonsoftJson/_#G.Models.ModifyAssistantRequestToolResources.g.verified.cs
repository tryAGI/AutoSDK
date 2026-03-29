//HintName: G.Models.ModifyAssistantRequestToolResources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
    /// </summary>
    public sealed partial class ModifyAssistantRequestToolResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_interpreter")]
        public global::G.ModifyAssistantRequestToolResourcesCodeInterpreter? CodeInterpreter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_search")]
        public global::G.ModifyAssistantRequestToolResourcesFileSearch? FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequestToolResources" /> class.
        /// </summary>
        /// <param name="codeInterpreter"></param>
        /// <param name="fileSearch"></param>
        public ModifyAssistantRequestToolResources(
            global::G.ModifyAssistantRequestToolResourcesCodeInterpreter? codeInterpreter,
            global::G.ModifyAssistantRequestToolResourcesFileSearch? fileSearch)
        {
            this.CodeInterpreter = codeInterpreter;
            this.FileSearch = fileSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyAssistantRequestToolResources" /> class.
        /// </summary>
        public ModifyAssistantRequestToolResources()
        {
        }
    }
}