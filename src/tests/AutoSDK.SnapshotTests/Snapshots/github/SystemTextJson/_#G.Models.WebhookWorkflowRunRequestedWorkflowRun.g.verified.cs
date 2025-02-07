//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowRunRequestedWorkflowRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunActor? Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArtifactsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CancelUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suite_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CheckSuiteId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suite_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckSuiteNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suite_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckSuiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowRunRequestedWorkflowRunConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunConclusion? Conclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HeadBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunHeadCommit HeadCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepository HeadRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LogsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_attempt_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? PreviousAttemptUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookWorkflowRunRequestedWorkflowRunPullRequest> PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_workflows")]
        public global::System.Collections.Generic.IList<global::G.WebhookWorkflowRunRequestedWorkflowRunReferencedWorkflow>? ReferencedWorkflows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunRepository Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerun_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RerunUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_attempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunAttempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime RunStartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookWorkflowRunRequestedWorkflowRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggering_actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActor? TriggeringActor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunRequestedWorkflowRun" /> class.
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
        /// <param name="displayTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookWorkflowRunRequestedWorkflowRun(
            global::G.WebhookWorkflowRunRequestedWorkflowRunActor? actor,
            string artifactsUrl,
            string cancelUrl,
            int checkSuiteId,
            string checkSuiteNodeId,
            string checkSuiteUrl,
            global::G.WebhookWorkflowRunRequestedWorkflowRunConclusion? conclusion,
            global::System.DateTime createdAt,
            string @event,
            string? headBranch,
            global::G.WebhookWorkflowRunRequestedWorkflowRunHeadCommit headCommit,
            global::G.WebhookWorkflowRunRequestedWorkflowRunHeadRepository headRepository,
            string headSha,
            string htmlUrl,
            int id,
            string jobsUrl,
            string logsUrl,
            string? name,
            string nodeId,
            string path,
            string? previousAttemptUrl,
            global::System.Collections.Generic.IList<global::G.WebhookWorkflowRunRequestedWorkflowRunPullRequest> pullRequests,
            global::G.WebhookWorkflowRunRequestedWorkflowRunRepository repository,
            string rerunUrl,
            int runAttempt,
            int runNumber,
            global::System.DateTime runStartedAt,
            global::G.WebhookWorkflowRunRequestedWorkflowRunStatus status,
            global::G.WebhookWorkflowRunRequestedWorkflowRunTriggeringActor? triggeringActor,
            global::System.DateTime updatedAt,
            string url,
            int workflowId,
            string workflowUrl,
            string displayTitle,
            global::System.Collections.Generic.IList<global::G.WebhookWorkflowRunRequestedWorkflowRunReferencedWorkflow>? referencedWorkflows)
        {
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.ArtifactsUrl = artifactsUrl ?? throw new global::System.ArgumentNullException(nameof(artifactsUrl));
            this.CancelUrl = cancelUrl ?? throw new global::System.ArgumentNullException(nameof(cancelUrl));
            this.CheckSuiteId = checkSuiteId;
            this.CheckSuiteNodeId = checkSuiteNodeId ?? throw new global::System.ArgumentNullException(nameof(checkSuiteNodeId));
            this.CheckSuiteUrl = checkSuiteUrl ?? throw new global::System.ArgumentNullException(nameof(checkSuiteUrl));
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.HeadBranch = headBranch ?? throw new global::System.ArgumentNullException(nameof(headBranch));
            this.HeadCommit = headCommit ?? throw new global::System.ArgumentNullException(nameof(headCommit));
            this.HeadRepository = headRepository ?? throw new global::System.ArgumentNullException(nameof(headRepository));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.JobsUrl = jobsUrl ?? throw new global::System.ArgumentNullException(nameof(jobsUrl));
            this.LogsUrl = logsUrl ?? throw new global::System.ArgumentNullException(nameof(logsUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.PreviousAttemptUrl = previousAttemptUrl ?? throw new global::System.ArgumentNullException(nameof(previousAttemptUrl));
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.RerunUrl = rerunUrl ?? throw new global::System.ArgumentNullException(nameof(rerunUrl));
            this.RunAttempt = runAttempt;
            this.RunNumber = runNumber;
            this.RunStartedAt = runStartedAt;
            this.Status = status;
            this.TriggeringActor = triggeringActor ?? throw new global::System.ArgumentNullException(nameof(triggeringActor));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.WorkflowId = workflowId;
            this.WorkflowUrl = workflowUrl ?? throw new global::System.ArgumentNullException(nameof(workflowUrl));
            this.DisplayTitle = displayTitle ?? throw new global::System.ArgumentNullException(nameof(displayTitle));
            this.ReferencedWorkflows = referencedWorkflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunRequestedWorkflowRun" /> class.
        /// </summary>
        public WebhookWorkflowRunRequestedWorkflowRun()
        {
        }
    }
}