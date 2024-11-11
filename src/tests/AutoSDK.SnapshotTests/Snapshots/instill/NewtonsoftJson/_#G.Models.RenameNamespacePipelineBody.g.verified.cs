//HintName: G.Models.RenameNamespacePipelineBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RenameNamespacePipelineRequest represents a request to rename the name of a<br/>
    /// pipeline owned by a namespace.
    /// </summary>
    public sealed partial class RenameNamespacePipelineBody
    {
        /// <summary>
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace.id}/pipelines/{new_pipeline_id}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newPipelineId", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewPipelineId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespacePipelineBody" /> class.
        /// </summary>
        /// <param name="newPipelineId">
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace.id}/pipelines/{new_pipeline_id}`.
        /// </param>
        public RenameNamespacePipelineBody(
            string newPipelineId)
        {
            this.NewPipelineId = newPipelineId ?? throw new global::System.ArgumentNullException(nameof(newPipelineId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespacePipelineBody" /> class.
        /// </summary>
        public RenameNamespacePipelineBody()
        {
        }
    }
}