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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The id of the associated workflow run.<br/>
        /// Example: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/runs/5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunUrl { get; set; }

        /// <summary>
        /// Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.<br/>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_attempt")]
        public int? RunAttempt { get; set; }

        /// <summary>
        /// Example: MDg6Q2hlY2tSdW40
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The SHA of the commit that is being run.<br/>
        /// Example: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HeadSha { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/github/hello-world/actions/jobs/21
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/github/hello-world/runs/4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HtmlUrl { get; set; }

        /// <summary>
        /// The phase of the lifecycle that the job is currently in.<br/>
        /// Example: queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JobStatus Status { get; set; }

        /// <summary>
        /// The outcome of the job.<br/>
        /// Example: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JobConclusion? Conclusion { get; set; }

        /// <summary>
        /// The time that the job created, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time that the job started, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// The time that the job finished, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The name of the job.<br/>
        /// Example: test-coverage
        /// </summary>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("check_run_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckRunUrl { get; set; }

        /// <summary>
        /// Labels for the workflow job. Specified by the "runs_on" attribute in the action's workflow file.<br/>
        /// Example: [self-hosted, foo, bar]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// The ID of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? RunnerId { get; set; }

        /// <summary>
        /// The name of the runner to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? RunnerName { get; set; }

        /// <summary>
        /// The ID of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? RunnerGroupId { get; set; }

        /// <summary>
        /// The name of the runner group to which this job has been assigned. (If a runner hasn't yet been assigned, this will be null.)<br/>
        /// Example: my runner group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? RunnerGroupName { get; set; }

        /// <summary>
        /// The name of the workflow.<br/>
        /// Example: Build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? WorkflowName { get; set; }

        /// <summary>
        /// The name of the current branch.<br/>
        /// Example: main
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HeadBranch { get; set; }

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
        /// The time that the job created, in ISO 8601 format.
        /// </param>
        /// <param name="startedAt">
        /// The time that the job started, in ISO 8601 format.
        /// </param>
        /// <param name="completedAt">
        /// The time that the job finished, in ISO 8601 format.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Job(
            int id,
            int runId,
            string runUrl,
            string nodeId,
            string headSha,
            string url,
            string? htmlUrl,
            global::G.JobStatus status,
            global::G.JobConclusion? conclusion,
            global::System.DateTime createdAt,
            global::System.DateTime startedAt,
            global::System.DateTime? completedAt,
            string name,
            string checkRunUrl,
            global::System.Collections.Generic.IList<string> labels,
            int? runnerId,
            string? runnerName,
            int? runnerGroupId,
            string? runnerGroupName,
            string? workflowName,
            string? headBranch,
            int? runAttempt,
            global::System.Collections.Generic.IList<global::G.JobStep>? steps)
        {
            this.Id = id;
            this.RunId = runId;
            this.RunUrl = runUrl ?? throw new global::System.ArgumentNullException(nameof(runUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Status = status;
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CheckRunUrl = checkRunUrl ?? throw new global::System.ArgumentNullException(nameof(checkRunUrl));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.RunnerId = runnerId;
            this.RunnerName = runnerName ?? throw new global::System.ArgumentNullException(nameof(runnerName));
            this.RunnerGroupId = runnerGroupId;
            this.RunnerGroupName = runnerGroupName ?? throw new global::System.ArgumentNullException(nameof(runnerGroupName));
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.HeadBranch = headBranch ?? throw new global::System.ArgumentNullException(nameof(headBranch));
            this.RunAttempt = runAttempt;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        public Job()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.Job? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Job),
                jsonSerializerContext) as global::G.Job;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Job? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Job>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Job?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Job),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Job;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Job?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Job?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}