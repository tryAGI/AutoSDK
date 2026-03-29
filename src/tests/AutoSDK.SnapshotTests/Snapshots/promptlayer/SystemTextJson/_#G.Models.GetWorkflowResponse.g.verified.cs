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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Unique identifier for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowId { get; set; }

        /// <summary>
        /// Name of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowName { get; set; }

        /// <summary>
        /// Version number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Unique identifier for this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowVersionId { get; set; }

        /// <summary>
        /// Commit message for this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Input variable names mapped to their types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_input_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequiredInputVariables { get; set; }

        /// <summary>
        /// Release labels attached to this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_labels")]
        public global::System.Collections.Generic.IList<string>? ReleaseLabels { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when this version was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Full node definitions including configuration and dependencies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetWorkflowResponseNode> Nodes { get; set; }

        /// <summary>
        /// Connections between nodes with optional conditionals
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetWorkflowResponseEdge> Edges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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