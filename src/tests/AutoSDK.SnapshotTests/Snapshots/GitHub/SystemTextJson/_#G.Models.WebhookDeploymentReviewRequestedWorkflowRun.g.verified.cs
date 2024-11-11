//HintName: G.Models.WebhookDeploymentReviewRequestedWorkflowRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentReviewRequestedWorkflowRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentReviewRequestedWorkflowRunActor? Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifacts_url")]
        public string? ArtifactsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_url")]
        public string? CancelUrl { get; set; }

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
        public string? CheckSuiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookDeploymentReviewRequestedWorkflowRunConclusionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentReviewRequestedWorkflowRunConclusion? Conclusion { get; set; }

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
        public required string HeadBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_commit")]
        public object? HeadCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head_repository")]
        public global::G.WebhookDeploymentReviewRequestedWorkflowRunHeadRepository? HeadRepository { get; set; }

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
        public string? JobsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs_url")]
        public string? LogsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        public string? PreviousAttemptUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewRequestedWorkflowRunPullRequest> PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_workflows")]
        public global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewRequestedWorkflowRunReferencedWorkflow>? ReferencedWorkflows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::G.WebhookDeploymentReviewRequestedWorkflowRunRepository? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerun_url")]
        public string? RerunUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookDeploymentReviewRequestedWorkflowRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentReviewRequestedWorkflowRunStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggering_actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentReviewRequestedWorkflowRunTriggeringActor? TriggeringActor { get; set; }

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
        public string? WorkflowUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRequestedWorkflowRun" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookDeploymentReviewRequestedWorkflowRun(
            global::G.WebhookDeploymentReviewRequestedWorkflowRunActor? actor,
            int checkSuiteId,
            string checkSuiteNodeId,
            global::G.WebhookDeploymentReviewRequestedWorkflowRunConclusion? conclusion,
            global::System.DateTime createdAt,
            string @event,
            string headBranch,
            string headSha,
            string htmlUrl,
            int id,
            string name,
            string nodeId,
            string path,
            global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewRequestedWorkflowRunPullRequest> pullRequests,
            int runAttempt,
            int runNumber,
            global::System.DateTime runStartedAt,
            global::G.WebhookDeploymentReviewRequestedWorkflowRunStatus status,
            global::G.WebhookDeploymentReviewRequestedWorkflowRunTriggeringActor? triggeringActor,
            global::System.DateTime updatedAt,
            string url,
            int workflowId,
            string displayTitle,
            string? artifactsUrl,
            string? cancelUrl,
            string? checkSuiteUrl,
            object? headCommit,
            global::G.WebhookDeploymentReviewRequestedWorkflowRunHeadRepository? headRepository,
            string? jobsUrl,
            string? logsUrl,
            string? previousAttemptUrl,
            global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewRequestedWorkflowRunReferencedWorkflow>? referencedWorkflows,
            global::G.WebhookDeploymentReviewRequestedWorkflowRunRepository? repository,
            string? rerunUrl,
            string? workflowUrl)
        {
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.CheckSuiteId = checkSuiteId;
            this.CheckSuiteNodeId = checkSuiteNodeId ?? throw new global::System.ArgumentNullException(nameof(checkSuiteNodeId));
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.HeadBranch = headBranch ?? throw new global::System.ArgumentNullException(nameof(headBranch));
            this.HeadSha = headSha ?? throw new global::System.ArgumentNullException(nameof(headSha));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.PullRequests = pullRequests ?? throw new global::System.ArgumentNullException(nameof(pullRequests));
            this.RunAttempt = runAttempt;
            this.RunNumber = runNumber;
            this.RunStartedAt = runStartedAt;
            this.Status = status;
            this.TriggeringActor = triggeringActor ?? throw new global::System.ArgumentNullException(nameof(triggeringActor));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.WorkflowId = workflowId;
            this.DisplayTitle = displayTitle ?? throw new global::System.ArgumentNullException(nameof(displayTitle));
            this.ArtifactsUrl = artifactsUrl;
            this.CancelUrl = cancelUrl;
            this.CheckSuiteUrl = checkSuiteUrl;
            this.HeadCommit = headCommit;
            this.HeadRepository = headRepository;
            this.JobsUrl = jobsUrl;
            this.LogsUrl = logsUrl;
            this.PreviousAttemptUrl = previousAttemptUrl;
            this.ReferencedWorkflows = referencedWorkflows;
            this.Repository = repository;
            this.RerunUrl = rerunUrl;
            this.WorkflowUrl = workflowUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRequestedWorkflowRun" /> class.
        /// </summary>
        public WebhookDeploymentReviewRequestedWorkflowRun()
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
        public static global::G.WebhookDeploymentReviewRequestedWorkflowRun? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.WebhookDeploymentReviewRequestedWorkflowRun),
                jsonSerializerContext) as global::G.WebhookDeploymentReviewRequestedWorkflowRun;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookDeploymentReviewRequestedWorkflowRun? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookDeploymentReviewRequestedWorkflowRun>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.WebhookDeploymentReviewRequestedWorkflowRun?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.WebhookDeploymentReviewRequestedWorkflowRun),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.WebhookDeploymentReviewRequestedWorkflowRun;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookDeploymentReviewRequestedWorkflowRun?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.WebhookDeploymentReviewRequestedWorkflowRun?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}