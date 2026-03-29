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
        [global::Newtonsoft.Json.JsonProperty("release_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReleaseLabel { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_label_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReleaseLabelId { get; set; } = default!;

        /// <summary>
        /// Version ID this label points to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkflowVersionId { get; set; } = default!;

        /// <summary>
        /// Version number this label points to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_version_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkflowVersionNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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