//HintName: G.Models.CloneNamespacePipelineReleaseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CloneNamespacePipelineReleaseRequest represents a request to clone a pipeline<br/>
    /// release owned by a user.
    /// </summary>
    public sealed partial class CloneNamespacePipelineReleaseBody
    {
        /// <summary>
        /// Pipeline description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Pipeline sharing information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sharing")]
        public global::G.Sharing? Sharing { get; set; }

        /// <summary>
        /// Target Namespace ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("targetNamespaceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetNamespaceId { get; set; } = default!;

        /// <summary>
        /// Target Pipeline ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("targetPipelineId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetPipelineId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneNamespacePipelineReleaseBody" /> class.
        /// </summary>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="targetNamespaceId">
        /// Target Namespace ID.
        /// </param>
        /// <param name="targetPipelineId">
        /// Target Pipeline ID.
        /// </param>
        public CloneNamespacePipelineReleaseBody(
            string targetNamespaceId,
            string targetPipelineId,
            string? description,
            global::G.Sharing? sharing)
        {
            this.TargetNamespaceId = targetNamespaceId ?? throw new global::System.ArgumentNullException(nameof(targetNamespaceId));
            this.TargetPipelineId = targetPipelineId ?? throw new global::System.ArgumentNullException(nameof(targetPipelineId));
            this.Description = description;
            this.Sharing = sharing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneNamespacePipelineReleaseBody" /> class.
        /// </summary>
        public CloneNamespacePipelineReleaseBody()
        {
        }
    }
}