//HintName: G.Models.CreateAssistantRequestToolResourcesCodeInterpreter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssistantRequestToolResourcesCodeInterpreter
    {
        /// <summary>
        /// A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantRequestToolResourcesCodeInterpreter" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool.<br/>
        /// Default Value: []
        /// </param>
        public CreateAssistantRequestToolResourcesCodeInterpreter(
            global::System.Collections.Generic.IList<string>? fileIds)
        {
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantRequestToolResourcesCodeInterpreter" /> class.
        /// </summary>
        public CreateAssistantRequestToolResourcesCodeInterpreter()
        {
        }
    }
}