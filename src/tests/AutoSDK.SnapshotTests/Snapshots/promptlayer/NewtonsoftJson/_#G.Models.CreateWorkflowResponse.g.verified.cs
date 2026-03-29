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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// The ID of the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkflowId { get; set; } = default!;

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowName { get; set; } = default!;

        /// <summary>
        /// The ID of the created workflow version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkflowVersionId { get; set; } = default!;

        /// <summary>
        /// The version number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionNumber { get; set; } = default!;

        /// <summary>
        /// The base version this was created from (PATCH only).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_version")]
        public int? BaseVersion { get; set; }

        /// <summary>
        /// Labels attached to this version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// Summary of nodes in the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes")]
        public global::System.Collections.Generic.IList<global::G.CreateWorkflowResponseNode>? Nodes { get; set; }

        /// <summary>
        /// Required input variables for the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequiredInputVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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