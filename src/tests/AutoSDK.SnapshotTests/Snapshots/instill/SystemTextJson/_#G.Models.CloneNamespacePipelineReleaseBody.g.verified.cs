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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Pipeline sharing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        public global::G.Sharing? Sharing { get; set; }

        /// <summary>
        /// Target Namespace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNamespaceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNamespaceId { get; set; }

        /// <summary>
        /// Target Pipeline ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetPipelineId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetPipelineId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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