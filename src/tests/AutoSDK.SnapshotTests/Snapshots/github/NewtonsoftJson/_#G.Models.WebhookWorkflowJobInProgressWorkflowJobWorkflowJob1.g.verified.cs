//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The workflow job. Many `workflow_job` keys, such as `head_sha`, `conclusion`, and `started_at` are the same as those in a [`check_run`](#check_run) object.
    /// </summary>
    public sealed partial class WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_run_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckRunUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion")]
        public global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion? Conclusion { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("runner_group_id")]
        public int? RunnerGroupId { get; set; }

        /// <summary>
        /// The name of the runner group that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_group_name")]
        public string? RunnerGroupName { get; set; }

        /// <summary>
        /// The ID of the runner that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_id")]
        public int? RunnerId { get; set; }

        /// <summary>
        /// The name of the runner that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_name")]
        public string? RunnerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartedAt { get; set; } = default!;

        /// <summary>
        /// The current status of the job. Can be `queued`, `in_progress`, or `completed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status Status { get; set; } = default!;

        /// <summary>
        /// The name of the current branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch")]
        public string? HeadBranch { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_name")]
        public string? WorkflowName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("steps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Step> Steps { get; set; } = default!;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1" /> class.
        /// </summary>
        /// <param name="checkRunUrl"></param>
        /// <param name="createdAt">
        /// The time that the job created.
        /// </param>
        /// <param name="headSha"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="labels">
        /// Custom labels for the job. Specified by the [`"runs-on"` attribute](https://docs.github.com/actions/reference/workflow-syntax-for-github-actions#jobsjob_idruns-on) in the workflow YAML.
        /// </param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="runAttempt"></param>
        /// <param name="runId"></param>
        /// <param name="runUrl"></param>
        /// <param name="startedAt"></param>
        /// <param name="status">
        /// The current status of the job. Can be `queued`, `in_progress`, or `completed`.
        /// </param>
        /// <param name="steps"></param>
        /// <param name="url"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </param>
        /// <param name="runnerGroupName">
        /// The name of the runner group that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </param>
        /// <param name="runnerId">
        /// The ID of the runner that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </param>
        /// <param name="runnerName">
        /// The name of the runner that is running this job. This will be `null` as long as `workflow_job[status]` is `queued`.
        /// </param>
        /// <param name="headBranch">
        /// The name of the current branch.
        /// </param>
        /// <param name="workflowName">
        /// The name of the workflow.
        /// </param>
        public WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1(
            string checkRunUrl,
            string createdAt,
            string headSha,
            string htmlUrl,
            int id,
            global::System.Collections.Generic.IList<string> labels,
            string name,
            string nodeId,
            int runAttempt,
            double runId,
            string runUrl,
            string startedAt,
            global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status status,
            global::System.Collections.Generic.IList<global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Step> steps,
            string url,
            string? completedAt,
            global::G.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Conclusion? conclusion,
            int? runnerGroupId,
            string? runnerGroupName,
            int? runnerId,
            string? runnerName,
            string? headBranch,
            string? workflowName)
        {
            this.CheckRunUrl = checkRunUrl ?? throw new global::System.ArgumentNullException(nameof(checkRunUrl));
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.RunAttempt = runAttempt;
            this.RunId = runId;
            this.RunUrl = runUrl ?? throw new global::System.ArgumentNullException(nameof(runUrl));
            this.RunnerGroupId = runnerGroupId;
            this.RunnerGroupName = runnerGroupName;
            this.RunnerId = runnerId;
            this.RunnerName = runnerName;
            this.StartedAt = startedAt ?? throw new global::System.ArgumentNullException(nameof(startedAt));
            this.Status = status;
            this.HeadBranch = headBranch;
            this.WorkflowName = workflowName;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1" /> class.
        /// </summary>
        public WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1()
        {
        }
    }
}