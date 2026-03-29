//HintName: G.Models.GetWorkflowLabelsResponseReleaseLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowLabelsResponseReleaseLabel
    {
        /// <summary>
        /// Label name (e.g. 'prod', 'staging')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseLabel { get; set; }

        /// <summary>
        /// Unique identifier for the label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_label_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReleaseLabelId { get; set; }

        /// <summary>
        /// Version ID this label points to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowVersionId { get; set; }

        /// <summary>
        /// Version number this label points to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowVersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowLabelsResponseReleaseLabel" /> class.
        /// </summary>
        /// <param name="releaseLabel">
        /// Label name (e.g. 'prod', 'staging')
        /// </param>
        /// <param name="releaseLabelId">
        /// Unique identifier for the label
        /// </param>
        /// <param name="workflowVersionId">
        /// Version ID this label points to
        /// </param>
        /// <param name="workflowVersionNumber">
        /// Version number this label points to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowLabelsResponseReleaseLabel(
            string releaseLabel,
            int releaseLabelId,
            int workflowVersionId,
            int workflowVersionNumber)
        {
            this.ReleaseLabel = releaseLabel ?? throw new global::System.ArgumentNullException(nameof(releaseLabel));
            this.ReleaseLabelId = releaseLabelId;
            this.WorkflowVersionId = workflowVersionId;
            this.WorkflowVersionNumber = workflowVersionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowLabelsResponseReleaseLabel" /> class.
        /// </summary>
        public GetWorkflowLabelsResponseReleaseLabel()
        {
        }
    }
}