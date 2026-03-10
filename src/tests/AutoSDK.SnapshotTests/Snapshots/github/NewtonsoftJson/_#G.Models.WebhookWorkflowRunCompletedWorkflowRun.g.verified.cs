//HintName: G.Models.WebhookWorkflowRunCompletedWorkflowRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowRunCompletedWorkflowRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor")]
        public global::G.WebhookWorkflowRunCompletedWorkflowRunActor? Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifacts_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ArtifactsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancel_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CancelUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_suite_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int CheckSuiteId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_suite_node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckSuiteNodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_suite_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CheckSuiteUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion")]
        public global::G.WebhookWorkflowRunCompletedWorkflowRunConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch")]
        public string? HeadBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowRunCompletedWorkflowRunHeadCommit HeadCommit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowRunCompletedWorkflowRunHeadRepository HeadRepository { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string LogsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_attempt_url")]
        public string? PreviousAttemptUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookWorkflowRunCompletedWorkflowRunPullRequest> PullRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenced_workflows")]
        public global::System.Collections.Generic.IList<global::G.WebhookWorkflowRunCompletedWorkflowRunReferencedWorkflow>? ReferencedWorkflows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowRunCompletedWorkflowRunRepository Repository { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rerun_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string RerunUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_attempt", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunAttempt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime RunStartedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowRunCompletedWorkflowRunStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggering_actor")]
        public global::G.WebhookWorkflowRunCompletedWorkflowRunTriggeringActor? TriggeringActor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkflowId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowUrl { get; set; } = default!;

        /// <summary>
        /// The event-specific title associated with the run or the run-name if set, or the value of `run-name` if it is set in the workflow.<br/>
        /// Example: Simple Workflow
        /// </summary>
        /// <example>Simple Workflow</example>
        [global::Newtonsoft.Json.JsonProperty("display_title")]
        public string? DisplayTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunCompletedWorkflowRun" /> class.
        /// </summary>
        /// <param name="actor"></param>
        /// <param name="artifactsUrl"></param>
        /// <param name="cancelUrl"></param>
        /// <param name="checkSuiteId"></param>
        /// <param name="checkSuiteNodeId"></param>
        /// <param name="checkSuiteUrl"></param>
        /// <param name="conclusion"></param>
        /// <param name="createdAt"></param>
        /// <param name="event"></param>
        /// <param name="headBranch"></param>
        /// <param name="headCommit"></param>
        /// <param name="headRepository"></param>
        /// <param name="headSha"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="jobsUrl"></param>
        /// <param name="logsUrl"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="path"></param>
        /// <param name="previousAttemptUrl"></param>
        /// <param name="pullRequests"></param>
        /// <param name="referencedWorkflows"></param>
        /// <param name="repository"></param>
        /// <param name="rerunUrl"></param>
        /// <param name="runAttempt"></param>
        /// <param name="runNumber"></param>
        /// <param name="runStartedAt"></param>
        /// <param name="status"></param>
        /// <param name="triggeringActor"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="workflowId"></param>
        /// <param name="workflowUrl"></param>
        /// <param name="displayTitle">
        /// The event-specific title associated with the run or the run-name if set, or the value of `run-name` if it is set in the workflow.<br/>
        /// Example: Simple Workflow
        /// </param>
        public WebhookWorkflowRunCompletedWorkflowRun(
            string artifactsUrl,
            string cancelUrl,
            int checkSuiteId,
            string checkSuiteNodeId,
            string checkSuiteUrl,
            global::System.DateTime createdAt,
            string @event,
            global::G.WebhookWorkflowRunCompletedWorkflowRunHeadCommit headCommit,
            global::G.WebhookWorkflowRunCompletedWorkflowRunHeadRepository headRepository,
            string headSha,
            string htmlUrl,
            int id,
            string jobsUrl,
            string logsUrl,
            string nodeId,
            string path,
            global::System.Collections.Generic.IList<global::G.WebhookWorkflowRunCompletedWorkflowRunPullRequest> pullRequests,
            global::G.WebhookWorkflowRunCompletedWorkflowRunRepository repository,
            string rerunUrl,
            int runAttempt,
            int runNumber,
            global::System.DateTime runStartedAt,
            global::G.WebhookWorkflowRunCompletedWorkflowRunStatus status,
            global::System.DateTime updatedAt,
            string url,
            int workflowId,
            string workflowUrl,
            global::G.WebhookWorkflowRunCompletedWorkflowRunActor? actor,
            global::G.WebhookWorkflowRunCompletedWorkflowRunConclusion? conclusion,
            string? headBranch,
            string? name,
            string? previousAttemptUrl,
            global::System.Collections.Generic.IList<global::G.WebhookWorkflowRunCompletedWorkflowRunReferencedWorkflow>? referencedWorkflows,
            global::G.WebhookWorkflowRunCompletedWorkflowRunTriggeringActor? triggeringActor,
            string? displayTitle)
        {
            this.ArtifactsUrl = artifactsUrl ?? throw new global::System.ArgumentNullException(nameof(artifactsUrl));
            this.CancelUrl = cancelUrl ?? throw new global::System.ArgumentNullException(nameof(cancelUrl));
            this.CheckSuiteId = checkSuiteId;
            this.CheckSuiteNodeId = checkSuiteNodeId ?? throw new global::System.ArgumentNullException(nameof(checkSuiteNodeId));
            this.CheckSuiteUrl = checkSuiteUrl ?? throw new global::System.ArgumentNullException(nameof(checkSuiteUrl));
            this.CreatedAt = createdAt;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.HeadCommit = headCommit ?? throw new global::System.ArgumentNullException(nameof(headCommit));
            this.HeadRepository = headRepository ?? throw new global::System.ArgumentNullException(nameof(headRepository));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.JobsUrl = jobsUrl ?? throw new global::System.ArgumentNullException(nameof(jobsUrl));
            this.LogsUrl = logsUrl ?? throw new global::System.ArgumentNullException(nameof(logsUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.RerunUrl = rerunUrl ?? throw new global::System.ArgumentNullException(nameof(rerunUrl));
            this.RunAttempt = runAttempt;
            this.RunNumber = runNumber;
            this.RunStartedAt = runStartedAt;
            this.Status = status;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.WorkflowId = workflowId;
            this.WorkflowUrl = workflowUrl ?? throw new global::System.ArgumentNullException(nameof(workflowUrl));
            this.Actor = actor;
            this.Conclusion = conclusion;
            this.HeadBranch = headBranch;
            this.Name = name;
            this.PreviousAttemptUrl = previousAttemptUrl;
            this.ReferencedWorkflows = referencedWorkflows;
            this.TriggeringActor = triggeringActor;
            this.DisplayTitle = displayTitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunCompletedWorkflowRun" /> class.
        /// </summary>
        public WebhookWorkflowRunCompletedWorkflowRun()
        {
        }
    }
}