//HintName: G.Models.WorkflowRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An invocation of a workflow
    /// </summary>
    public sealed partial class WorkflowRun
    {
        /// <summary>
        /// The ID of the workflow run.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The name of the workflow run.<br/>
        /// Example: Build
        /// </summary>
        /// <example>Build</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </summary>
        /// <example>MDEwOkNoZWNrU3VpdGU1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The ID of the associated check suite.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suite_id")]
        public int? CheckSuiteId { get; set; }

        /// <summary>
        /// The node ID of the associated check suite.<br/>
        /// Example: MDEwOkNoZWNrU3VpdGU0Mg==
        /// </summary>
        /// <example>MDEwOkNoZWNrU3VpdGU0Mg==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suite_node_id")]
        public string? CheckSuiteNodeId { get; set; }

        /// <summary>
        /// Example: master
        /// </summary>
        /// <example>master</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HeadBranch { get; set; }

        /// <summary>
        /// The SHA of the head commit that points to the version of the workflow being run.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        /// <example>009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// The full path of the workflow<br/>
        /// Example: octocat/octo-repo/.github/workflows/ci.yml@main
        /// </summary>
        /// <example>octocat/octo-repo/.github/workflows/ci.yml@main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The auto incrementing run number for the workflow run.<br/>
        /// Example: 106
        /// </summary>
        /// <example>106</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunNumber { get; set; }

        /// <summary>
        /// Attempt number of the run, 1 for first attempt and higher if the workflow was re-run.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_attempt")]
        public int? RunAttempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_workflows")]
        public global::System.Collections.Generic.IList<global::G.ReferencedWorkflow>? ReferencedWorkflows { get; set; }

        /// <summary>
        /// Example: push
        /// </summary>
        /// <example>push</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Status { get; set; }

        /// <summary>
        /// Example: neutral
        /// </summary>
        /// <example>neutral</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Conclusion { get; set; }

        /// <summary>
        /// The ID of the parent workflow.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkflowId { get; set; }

        /// <summary>
        /// The URL to the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/github/hello-world/suites/4
        /// </summary>
        /// <example>https://github.com/github/hello-world/suites/4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Pull requests that are open with a `head_sha` or `head_branch` that matches the workflow run. The returned pull requests do not necessarily indicate pull requests that triggered the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PullRequestMinimal>? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public global::G.SimpleUser? Actor { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggering_actor")]
        public global::G.SimpleUser? TriggeringActor { get; set; }

        /// <summary>
        /// The start time of the latest run. Resets on re-run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_started_at")]
        public global::System.DateTime? RunStartedAt { get; set; }

        /// <summary>
        /// The URL to the jobs for the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/jobs
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5/jobs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobsUrl { get; set; }

        /// <summary>
        /// The URL to download the logs for the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/logs
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5/logs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LogsUrl { get; set; }

        /// <summary>
        /// The URL to the associated check suite.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/check-suites/12
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/check-suites/12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_suite_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckSuiteUrl { get; set; }

        /// <summary>
        /// The URL to the artifacts for the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/rerun/artifacts
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5/rerun/artifacts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArtifactsUrl { get; set; }

        /// <summary>
        /// The URL to cancel the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/cancel
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5/cancel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CancelUrl { get; set; }

        /// <summary>
        /// The URL to rerun the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/rerun
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5/rerun</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerun_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RerunUrl { get; set; }

        /// <summary>
        /// The URL to the previous attempted run of this workflow, if one exists.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/attempts/3
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5/attempts/3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_attempt_url")]
        public string? PreviousAttemptUrl { get; set; }

        /// <summary>
        /// The URL to the workflow.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/workflows/main.yaml
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/workflows/main.yaml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowUrl { get; set; }

        /// <summary>
        /// A commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleCommit? HeadCommit { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MinimalRepository Repository { get; set; }

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MinimalRepository HeadRepository { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_repository_id")]
        public int? HeadRepositoryId { get; set; }

        /// <summary>
        /// The event-specific title associated with the run or the run-name if set, or the value of `run-name` if it is set in the workflow.<br/>
        /// Example: Simple Workflow
        /// </summary>
        /// <example>Simple Workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRun" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the workflow run.<br/>
        /// Example: 5
        /// </param>
        /// <param name="name">
        /// The name of the workflow run.<br/>
        /// Example: Build
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEwOkNoZWNrU3VpdGU1
        /// </param>
        /// <param name="checkSuiteId">
        /// The ID of the associated check suite.<br/>
        /// Example: 42
        /// </param>
        /// <param name="checkSuiteNodeId">
        /// The node ID of the associated check suite.<br/>
        /// Example: MDEwOkNoZWNrU3VpdGU0Mg==
        /// </param>
        /// <param name="headBranch">
        /// Example: master
        /// </param>
        /// <param name="headSha">
        /// The SHA of the head commit that points to the version of the workflow being run.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </param>
        /// <param name="path">
        /// The full path of the workflow<br/>
        /// Example: octocat/octo-repo/.github/workflows/ci.yml@main
        /// </param>
        /// <param name="runNumber">
        /// The auto incrementing run number for the workflow run.<br/>
        /// Example: 106
        /// </param>
        /// <param name="runAttempt">
        /// Attempt number of the run, 1 for first attempt and higher if the workflow was re-run.<br/>
        /// Example: 1
        /// </param>
        /// <param name="referencedWorkflows"></param>
        /// <param name="event">
        /// Example: push
        /// </param>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="conclusion">
        /// Example: neutral
        /// </param>
        /// <param name="workflowId">
        /// The ID of the parent workflow.<br/>
        /// Example: 5
        /// </param>
        /// <param name="url">
        /// The URL to the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/github/hello-world/suites/4
        /// </param>
        /// <param name="pullRequests">
        /// Pull requests that are open with a `head_sha` or `head_branch` that matches the workflow run. The returned pull requests do not necessarily indicate pull requests that triggered the run.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="actor">
        /// A GitHub user.
        /// </param>
        /// <param name="triggeringActor">
        /// A GitHub user.
        /// </param>
        /// <param name="runStartedAt">
        /// The start time of the latest run. Resets on re-run.
        /// </param>
        /// <param name="jobsUrl">
        /// The URL to the jobs for the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/jobs
        /// </param>
        /// <param name="logsUrl">
        /// The URL to download the logs for the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/logs
        /// </param>
        /// <param name="checkSuiteUrl">
        /// The URL to the associated check suite.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/check-suites/12
        /// </param>
        /// <param name="artifactsUrl">
        /// The URL to the artifacts for the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/rerun/artifacts
        /// </param>
        /// <param name="cancelUrl">
        /// The URL to cancel the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/cancel
        /// </param>
        /// <param name="rerunUrl">
        /// The URL to rerun the workflow run.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/rerun
        /// </param>
        /// <param name="previousAttemptUrl">
        /// The URL to the previous attempted run of this workflow, if one exists.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5/attempts/3
        /// </param>
        /// <param name="workflowUrl">
        /// The URL to the workflow.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/actions/workflows/main.yaml
        /// </param>
        /// <param name="headCommit">
        /// A commit.
        /// </param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="headRepository">
        /// Minimal Repository
        /// </param>
        /// <param name="headRepositoryId">
        /// Example: 5
        /// </param>
        /// <param name="displayTitle">
        /// The event-specific title associated with the run or the run-name if set, or the value of `run-name` if it is set in the workflow.<br/>
        /// Example: Simple Workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRun(
            int id,
            string nodeId,
            string? headBranch,
            string headSha,
            string path,
            int runNumber,
            string @event,
            string? status,
            string? conclusion,
            int workflowId,
            string url,
            string htmlUrl,
            global::System.Collections.Generic.IList<global::G.PullRequestMinimal>? pullRequests,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string jobsUrl,
            string logsUrl,
            string checkSuiteUrl,
            string artifactsUrl,
            string cancelUrl,
            string rerunUrl,
            string workflowUrl,
            global::G.NullableSimpleCommit? headCommit,
            global::G.MinimalRepository repository,
            global::G.MinimalRepository headRepository,
            string displayTitle,
            string? name,
            int? checkSuiteId,
            string? checkSuiteNodeId,
            int? runAttempt,
            global::System.Collections.Generic.IList<global::G.ReferencedWorkflow>? referencedWorkflows,
            global::G.SimpleUser? actor,
            global::G.SimpleUser? triggeringActor,
            global::System.DateTime? runStartedAt,
            string? previousAttemptUrl,
            int? headRepositoryId)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HeadBranch = headBranch ?? throw new global::System.ArgumentNullException(nameof(headBranch));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.RunNumber = runNumber;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Conclusion = conclusion ?? throw new global::System.ArgumentNullException(nameof(conclusion));
            this.WorkflowId = workflowId;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.JobsUrl = jobsUrl ?? throw new global::System.ArgumentNullException(nameof(jobsUrl));
            this.LogsUrl = logsUrl ?? throw new global::System.ArgumentNullException(nameof(logsUrl));
            this.CheckSuiteUrl = checkSuiteUrl ?? throw new global::System.ArgumentNullException(nameof(checkSuiteUrl));
            this.ArtifactsUrl = artifactsUrl ?? throw new global::System.ArgumentNullException(nameof(artifactsUrl));
            this.CancelUrl = cancelUrl ?? throw new global::System.ArgumentNullException(nameof(cancelUrl));
            this.RerunUrl = rerunUrl ?? throw new global::System.ArgumentNullException(nameof(rerunUrl));
            this.WorkflowUrl = workflowUrl ?? throw new global::System.ArgumentNullException(nameof(workflowUrl));
            this.HeadCommit = headCommit ?? throw new global::System.ArgumentNullException(nameof(headCommit));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.HeadRepository = headRepository ?? throw new global::System.ArgumentNullException(nameof(headRepository));
            this.DisplayTitle = displayTitle ?? throw new global::System.ArgumentNullException(nameof(displayTitle));
            this.Name = name;
            this.CheckSuiteId = checkSuiteId;
            this.CheckSuiteNodeId = checkSuiteNodeId;
            this.RunAttempt = runAttempt;
            this.ReferencedWorkflows = referencedWorkflows;
            this.Actor = actor;
            this.TriggeringActor = triggeringActor;
            this.RunStartedAt = runStartedAt;
            this.PreviousAttemptUrl = previousAttemptUrl;
            this.HeadRepositoryId = headRepositoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRun" /> class.
        /// </summary>
        public WorkflowRun()
        {
        }
    }
}