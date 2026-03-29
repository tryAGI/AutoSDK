//HintName: G.Models.GetWorkflowResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowResponse
    {
        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkflowId { get; set; } = default!;

        /// <summary>
        /// Name of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowName { get; set; } = default!;

        /// <summary>
        /// Version number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// Unique identifier for this version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkflowVersionId { get; set; } = default!;

        /// <summary>
        /// Commit message for this version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Input variable names mapped to their types
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required_input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequiredInputVariables { get; set; }

        /// <summary>
        /// Release labels attached to this version
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when this version was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Full node definitions including configuration and dependencies
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetWorkflowResponseNode> Nodes { get; set; } = default!;

        /// <summary>
        /// Connections between nodes with optional conditionals
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edges", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetWorkflowResponseEdge> Edges { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Example: true
        /// </param>
        /// <param name="workflowId">
        /// Unique identifier for the agent
        /// </param>
        /// <param name="workflowName">
        /// Name of the agent
        /// </param>
        /// <param name="version">
        /// Version number
        /// </param>
        /// <param name="workflowVersionId">
        /// Unique identifier for this version
        /// </param>
        /// <param name="nodes">
        /// Full node definitions including configuration and dependencies
        /// </param>
        /// <param name="edges">
        /// Connections between nodes with optional conditionals
        /// </param>
        /// <param name="commitMessage">
        /// Commit message for this version
        /// </param>
        /// <param name="requiredInputVariables">
        /// Input variable names mapped to their types
        /// </param>
        /// <param name="releaseLabels">
        /// Release labels attached to this version
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when this version was created
        /// </param>
        public GetWorkflowResponse(
            bool success,
            int workflowId,
            string workflowName,
            int version,
            int workflowVersionId,
            global::System.Collections.Generic.IList<global::G.GetWorkflowResponseNode> nodes,
            global::System.Collections.Generic.IList<global::G.GetWorkflowResponseEdge> edges,
            string? commitMessage,
            global::System.Collections.Generic.Dictionary<string, string>? requiredInputVariables,
            global::System.Collections.Generic.IList<string>? releaseLabels,
            string? createdAt)
        {
            this.Success = success;
            this.WorkflowId = workflowId;
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.Version = version;
            this.WorkflowVersionId = workflowVersionId;
            this.CommitMessage = commitMessage;
            this.RequiredInputVariables = requiredInputVariables;
            this.ReleaseLabels = releaseLabels;
            this.CreatedAt = createdAt;
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowResponse" /> class.
        /// </summary>
        public GetWorkflowResponse()
        {
        }
    }
}