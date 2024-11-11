//HintName: G.Models.ActionsListWorkflowRunsForRepoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListWorkflowRunsForRepoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WorkflowRun> WorkflowRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListWorkflowRunsForRepoResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="workflowRuns"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsListWorkflowRunsForRepoResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.WorkflowRun> workflowRuns)
        {
            this.TotalCount = totalCount;
            this.WorkflowRuns = workflowRuns ?? throw new global::System.ArgumentNullException(nameof(workflowRuns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListWorkflowRunsForRepoResponse" /> class.
        /// </summary>
        public ActionsListWorkflowRunsForRepoResponse()
        {
        }
    }
}