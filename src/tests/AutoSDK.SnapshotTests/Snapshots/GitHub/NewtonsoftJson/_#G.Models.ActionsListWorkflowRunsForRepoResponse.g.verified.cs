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
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_runs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WorkflowRun> WorkflowRuns { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListWorkflowRunsForRepoResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="workflowRuns"></param>
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