//HintName: G.Models.ThreadObjectToolResources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of resources that are made available to the assistant's tools in this thread. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
    /// </summary>
    public sealed partial class ThreadObjectToolResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_interpreter")]
        public ThreadObjectToolResourcesCodeInterpreter? CodeInterpreter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_search")]
        public ThreadObjectToolResourcesFileSearch? FileSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}