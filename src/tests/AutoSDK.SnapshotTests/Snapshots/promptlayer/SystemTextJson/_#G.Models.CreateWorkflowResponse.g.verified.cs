//HintName: G.Models.CreateWorkflowResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response after creating or patching a workflow.
    /// </summary>
    public sealed partial class CreateWorkflowResponse
    {
        /// <summary>
        /// Indicates if the request was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The ID of the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowId { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowName { get; set; }

        /// <summary>
        /// The ID of the created workflow version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowVersionId { get; set; }

        /// <summary>
        /// The version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionNumber { get; set; }

        /// <summary>
        /// The base version this was created from (PATCH only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_version")]
        public int? BaseVersion { get; set; }

        /// <summary>
        /// Labels attached to this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Summary of nodes in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::System.Collections.Generic.IList<global::G.CreateWorkflowResponseNode>? Nodes { get; set; }

        /// <summary>
        /// Required input variables for the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequiredInputVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates if the request was successful.
        /// </param>
        /// <param name="workflowId">
        /// The ID of the workflow.
        /// </param>
        /// <param name="workflowName">
        /// The name of the workflow.
        /// </param>
        /// <param name="workflowVersionId">
        /// The ID of the created workflow version.
        /// </param>
        /// <param name="versionNumber">
        /// The version number.
        /// </param>
        /// <param name="baseVersion">
        /// The base version this was created from (PATCH only).
        /// </param>
        /// <param name="releaseLabels">
        /// Labels attached to this version.
        /// </param>
        /// <param name="nodes">
        /// Summary of nodes in the workflow.
        /// </param>
        /// <param name="requiredInputVariables">
        /// Required input variables for the workflow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowResponse(
            bool success,
            int workflowId,
            string workflowName,
            int workflowVersionId,
            int versionNumber,
            int? baseVersion,
            global::System.Collections.Generic.IList<string>? releaseLabels,
            global::System.Collections.Generic.IList<global::G.CreateWorkflowResponseNode>? nodes,
            global::System.Collections.Generic.Dictionary<string, string>? requiredInputVariables)
        {
            this.Success = success;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.WorkflowVersionId = workflowVersionId;
            this.VersionNumber = versionNumber;
            this.BaseVersion = baseVersion;
            this.ReleaseLabels = releaseLabels;
            this.Nodes = nodes;
            this.RequiredInputVariables = requiredInputVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowResponse" /> class.
        /// </summary>
        public CreateWorkflowResponse()
        {
        }
    }
}