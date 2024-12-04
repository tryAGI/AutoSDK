//HintName: G.Models.CreateThreadAndRunRequestToolResourcesCodeInterpreter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadAndRunRequestToolResourcesCodeInterpreter
    {
        /// <summary>
        /// A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadAndRunRequestToolResourcesCodeInterpreter" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// A list of [file](/docs/api-reference/files) IDs made available to the `code_interpreter` tool. There can be a maximum of 20 files associated with the tool.<br/>
        /// Default Value: []
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateThreadAndRunRequestToolResourcesCodeInterpreter(
            global::System.Collections.Generic.IList<string>? fileIds)
        {
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadAndRunRequestToolResourcesCodeInterpreter" /> class.
        /// </summary>
        public CreateThreadAndRunRequestToolResourcesCodeInterpreter()
        {
        }
    }
}