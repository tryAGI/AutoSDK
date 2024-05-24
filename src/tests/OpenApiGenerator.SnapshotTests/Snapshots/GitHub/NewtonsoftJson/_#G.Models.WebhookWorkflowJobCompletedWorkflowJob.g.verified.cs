//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The workflow job. Many `workflow_job` keys, such as `head_sha`, `conclusion`, and `started_at` are the same as those in a [`check_run`](#check_run) object.
    /// </summary>
    public sealed partial class WebhookWorkflowJobCompletedWorkflowJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_run_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckRunUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CompletedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookWorkflowJobCompletedWorkflowJobConclusion? Conclusion { get; set; } = default!;

        /// <summary>
        /// The time that the job created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadSha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Custom labels for the job. Specified by the [`"runs-on"` attribute](https://docs.github.com/actions/reference/workflow-syntax-for-github-actions#jobsjob_idruns-on) in the workflow YAML.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Labels { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_attempt", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunAttempt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double RunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RunUrl { get; set; } = default!;

        /// <summary>
        /// The ID of the runner group that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? RunnerGroupId { get; set; } = default!;

        /// <summary>
        /// The name of the runner group that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_group_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RunnerGroupName { get; set; } = default!;

        /// <summary>
        /// The ID of the runner that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? RunnerId { get; set; } = default!;

        /// <summary>
        /// The name of the runner that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RunnerName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartedAt { get; set; } = default!;

        /// <summary>
        /// The current status of the job. Can be `queued`, `in_progress`, `waiting`, or `completed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public WebhookWorkflowJobCompletedWorkflowJobStatus Status { get; set; } = default!;

        /// <summary>
        /// The name of the current branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HeadBranch { get; set; } = default!;

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? WorkflowName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<WebhookWorkflowJobCompletedWorkflowJobSteps> Steps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}