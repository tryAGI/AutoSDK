//HintName: G.Models.WebhookDeploymentReviewApprovedWorkflowRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentReviewApprovedWorkflowRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentReviewApprovedWorkflowRunActor? Actor { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifacts_url")]
        public string? ArtifactsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancel_url")]
        public string? CancelUrl { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("check_suite_url")]
        public string? CheckSuiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusion? Conclusion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_title", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayTitle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string HeadBranch { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_commit")]
        public object? HeadCommit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_repository")]
        public global::G.WebhookDeploymentReviewApprovedWorkflowRunHeadRepository? HeadRepository { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("jobs_url")]
        public string? JobsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs_url")]
        public string? LogsUrl { get; set; }

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
        public global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewApprovedWorkflowRunPullRequest> PullRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenced_workflows")]
        public global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewApprovedWorkflowRunReferencedWorkflow>? ReferencedWorkflows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.WebhookDeploymentReviewApprovedWorkflowRunRepository? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rerun_url")]
        public string? RerunUrl { get; set; }

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
        public global::G.WebhookDeploymentReviewApprovedWorkflowRunStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggering_actor", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDeploymentReviewApprovedWorkflowRunTriggeringActor? TriggeringActor { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("workflow_url")]
        public string? WorkflowUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewApprovedWorkflowRun" /> class.
        /// </summary>
        /// <param name="actor"></param>
        /// <param name="artifactsUrl"></param>
        /// <param name="cancelUrl"></param>
        /// <param name="checkSuiteId"></param>
        /// <param name="checkSuiteNodeId"></param>
        /// <param name="checkSuiteUrl"></param>
        /// <param name="conclusion"></param>
        /// <param name="createdAt"></param>
        /// <param name="displayTitle"></param>
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
        public WebhookDeploymentReviewApprovedWorkflowRun(
            global::G.WebhookDeploymentReviewApprovedWorkflowRunActor? actor,
            int checkSuiteId,
            string checkSuiteNodeId,
            global::G.WebhookDeploymentReviewApprovedWorkflowRunConclusion? conclusion,
            global::System.DateTime createdAt,
            string displayTitle,
            string @event,
            string headBranch,
            string headSha,
            string htmlUrl,
            int id,
            string name,
            string nodeId,
            string path,
            global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewApprovedWorkflowRunPullRequest> pullRequests,
            int runAttempt,
            int runNumber,
            global::System.DateTime runStartedAt,
            global::G.WebhookDeploymentReviewApprovedWorkflowRunStatus status,
            global::G.WebhookDeploymentReviewApprovedWorkflowRunTriggeringActor? triggeringActor,
            global::System.DateTime updatedAt,
            string url,
            int workflowId,
            string? artifactsUrl,
            string? cancelUrl,
            string? checkSuiteUrl,
            object? headCommit,
            global::G.WebhookDeploymentReviewApprovedWorkflowRunHeadRepository? headRepository,
            string? jobsUrl,
            string? logsUrl,
            string? previousAttemptUrl,
            global::System.Collections.Generic.IList<global::G.WebhookDeploymentReviewApprovedWorkflowRunReferencedWorkflow>? referencedWorkflows,
            global::G.WebhookDeploymentReviewApprovedWorkflowRunRepository? repository,
            string? rerunUrl,
            string? workflowUrl)
        {
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.CheckSuiteId = checkSuiteId;
            this.CheckSuiteNodeId = checkSuiteNodeId ?? throw new global::System.ArgumentNullException(nameof(checkSuiteNodeId));
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.DisplayTitle = displayTitle ?? throw new global::System.ArgumentNullException(nameof(displayTitle));
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
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewApprovedWorkflowRun" /> class.
        /// </summary>
        public WebhookDeploymentReviewApprovedWorkflowRun()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookDeploymentReviewApprovedWorkflowRun? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookDeploymentReviewApprovedWorkflowRun>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookDeploymentReviewApprovedWorkflowRun?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookDeploymentReviewApprovedWorkflowRun?>(serializer.Deserialize<global::G.WebhookDeploymentReviewApprovedWorkflowRun>(jsonReader));
        }

    }
}