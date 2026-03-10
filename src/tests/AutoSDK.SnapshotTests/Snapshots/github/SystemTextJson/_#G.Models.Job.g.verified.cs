//HintName: G.Models.Job.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information of a job execution in a workflow run
    /// </summary>
    public sealed partial class Job
    {
        /// <summary>
        /// The id of the job.<br/>
        /// Example: 21
        /// </summary>
        /// <example>21</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The id of the associated workflow run.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/runs/5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunUrl { get; set; }

        /// <summary>
        /// Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_attempt")]
        public int? RunAttempt { get; set; }

        /// <summary>
        /// Example: MDg6Q2hlY2tSdW40
        /// </summary>
        /// <example>MDg6Q2hlY2tSdW40</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The SHA of the commit that is being run.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        /// <example>009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/jobs/21
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/actions/jobs/21</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/github/hello-world/runs/4
        /// </summary>
        /// <example>https://github.com/github/hello-world/runs/4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The phase of the lifecycle that the job is currently in.<br/>
        /// Example: queued
        /// </summary>
        /// <example>queued</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JobStatus Status { get; set; }

        /// <summary>
        /// The outcome of the job.<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobConclusionJsonConverter))]
        public global::G.JobConclusion? Conclusion { get; set; }

        /// <summary>
        /// The time that the job created, in ISO 8601 format.<br/>
        /// Example: 2019-08-08T08:00:00-07:00
        /// </summary>
        /// <example>2019-08-08T08:00:00-07:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time that the job started, in ISO 8601 format.<br/>
        /// Example: 2019-08-08T08:00:00-07:00
        /// </summary>
        /// <example>2019-08-08T08:00:00-07:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// The time that the job finished, in ISO 8601 format.<br/>
        /// Example: 2019-08-08T08:00:00-07:00
        /// </summary>
        /// <example>2019-08-08T08:00:00-07:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The name of the job.<br/>
        /// Example: test-coverage
        /// </summary>
        /// <example>test-coverage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Steps in this job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::G.JobStep>? Steps { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/check-runs/4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_run_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckRunUrl { get; set; }

        /// <summary>
        /// Labels for the workflow job. Specified by the "runs_on" attribute in the action's workflow file.<br/>
        /// Example: [self-hosted, foo, bar]
        /// </summary>
        /// <example>[self-hosted, foo, bar]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// The ID of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_id")]
        public int? RunnerId { get; set; }

        /// <summary>
        /// The name of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner
        /// </summary>
        /// <example>my runner</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_name")]
        public string? RunnerName { get; set; }

        /// <summary>
        /// The ID of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_id")]
        public int? RunnerGroupId { get; set; }

        /// <summary>
        /// The name of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner group
        /// </summary>
        /// <example>my runner group</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_name")]
        public string? RunnerGroupName { get; set; }

        /// <summary>
        /// The name of the workflow.<br/>
        /// Example: Build
        /// </summary>
        /// <example>Build</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        public string? WorkflowName { get; set; }

        /// <summary>
        /// The name of the current branch.<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_branch")]
        public string? HeadBranch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the job.<br/>
        /// Example: 21
        /// </param>
        /// <param name="runId">
        /// The id of the associated workflow run.<br/>
        /// Example: 5
        /// </param>
        /// <param name="runUrl">
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5
        /// </param>
        /// <param name="runAttempt">
        /// Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.<br/>
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDg6Q2hlY2tSdW40
        /// </param>
        /// <param name="headSha">
        /// The SHA of the commit that is being run.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/hello-world/actions/jobs/21
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/github/hello-world/runs/4
        /// </param>
        /// <param name="status">
        /// The phase of the lifecycle that the job is currently in.<br/>
        /// Example: queued
        /// </param>
        /// <param name="conclusion">
        /// The outcome of the job.<br/>
        /// Example: success
        /// </param>
        /// <param name="createdAt">
        /// The time that the job created, in ISO 8601 format.<br/>
        /// Example: 2019-08-08T08:00:00-07:00
        /// </param>
        /// <param name="startedAt">
        /// The time that the job started, in ISO 8601 format.<br/>
        /// Example: 2019-08-08T08:00:00-07:00
        /// </param>
        /// <param name="completedAt">
        /// The time that the job finished, in ISO 8601 format.<br/>
        /// Example: 2019-08-08T08:00:00-07:00
        /// </param>
        /// <param name="name">
        /// The name of the job.<br/>
        /// Example: test-coverage
        /// </param>
        /// <param name="steps">
        /// Steps in this job.
        /// </param>
        /// <param name="checkRunUrl">
        /// Example: https://api.github.com/repos/github/hello-world/check-runs/4
        /// </param>
        /// <param name="labels">
        /// Labels for the workflow job. Specified by the "runs_on" attribute in the action's workflow file.<br/>
        /// Example: [self-hosted, foo, bar]
        /// </param>
        /// <param name="runnerId">
        /// The ID of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 1
        /// </param>
        /// <param name="runnerName">
        /// The name of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner
        /// </param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 2
        /// </param>
        /// <param name="runnerGroupName">
        /// The name of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner group
        /// </param>
        /// <param name="workflowName">
        /// The name of the workflow.<br/>
        /// Example: Build
        /// </param>
        /// <param name="headBranch">
        /// The name of the current branch.<br/>
        /// Example: main
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Job(
            int id,
            int runId,
            string runUrl,
            string nodeId,
            string headSha,
            string url,
            global::G.JobStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime startedAt,
            string name,
            string checkRunUrl,
            global::System.Collections.Generic.IList<string> labels,
            int? runAttempt,
            string? htmlUrl,
            global::G.JobConclusion? conclusion,
            global::System.DateTime? completedAt,
            global::System.Collections.Generic.IList<global::G.JobStep>? steps,
            int? runnerId,
            string? runnerName,
            int? runnerGroupId,
            string? runnerGroupName,
            string? workflowName,
            string? headBranch)
        {
            this.Id = id;
            this.RunId = runId;
            this.RunUrl = runUrl ?? throw new global::System.ArgumentNullException(nameof(runUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CheckRunUrl = checkRunUrl ?? throw new global::System.ArgumentNullException(nameof(checkRunUrl));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.RunAttempt = runAttempt;
            this.HtmlUrl = htmlUrl;
            this.Conclusion = conclusion;
            this.CompletedAt = completedAt;
            this.Steps = steps;
            this.RunnerId = runnerId;
            this.RunnerName = runnerName;
            this.RunnerGroupId = runnerGroupId;
            this.RunnerGroupName = runnerGroupName;
            this.WorkflowName = workflowName;
            this.HeadBranch = headBranch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }
    }
}