//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowJobInProgressWorkflowJobVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_run_url")]
        public string? CheckRunUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conclusion")]
        public string? Conclusion { get; set; }

        /// <summary>
        /// The time that the job created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head_sha")]
        public string? HeadSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_attempt")]
        public int? RunAttempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public int? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_url")]
        public string? RunUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_group_id")]
        public double? RunnerGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_group_name")]
        public string? RunnerGroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_id")]
        public double? RunnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_name")]
        public string? RunnerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2Status Status { get; set; } = default!;

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
        public global::System.Collections.Generic.IList<global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2Step> Steps { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobInProgressWorkflowJobVariant2" /> class.
        /// </summary>
        /// <param name="checkRunUrl"></param>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
        /// <param name="createdAt">
        /// The time that the job created.
        /// </param>
        /// <param name="headSha"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="labels"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="runAttempt"></param>
        /// <param name="runId"></param>
        /// <param name="runUrl"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="runnerGroupName"></param>
        /// <param name="runnerId"></param>
        /// <param name="runnerName"></param>
        /// <param name="startedAt"></param>
        /// <param name="status"></param>
        /// <param name="headBranch">
        /// The name of the current branch.
        /// </param>
        /// <param name="workflowName">
        /// The name of the workflow.
        /// </param>
        /// <param name="steps"></param>
        /// <param name="url"></param>
        public WebhookWorkflowJobInProgressWorkflowJobVariant2(
            global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2Status status,
            global::System.Collections.Generic.IList<global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2Step> steps,
            string? checkRunUrl,
            string? completedAt,
            string? conclusion,
            string? createdAt,
            string? headSha,
            string? htmlUrl,
            int? id,
            global::System.Collections.Generic.IList<string>? labels,
            string? name,
            string? nodeId,
            int? runAttempt,
            int? runId,
            string? runUrl,
            double? runnerGroupId,
            string? runnerGroupName,
            double? runnerId,
            string? runnerName,
            string? startedAt,
            string? headBranch,
            string? workflowName,
            string? url)
        {
            this.Status = status;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.CheckRunUrl = checkRunUrl;
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
            this.CreatedAt = createdAt;
            this.HeadSha = headSha;
            this.HtmlUrl = htmlUrl;
            this.Id = id;
            this.Labels = labels;
            this.Name = name;
            this.NodeId = nodeId;
            this.RunAttempt = runAttempt;
            this.RunId = runId;
            this.RunUrl = runUrl;
            this.RunnerGroupId = runnerGroupId;
            this.RunnerGroupName = runnerGroupName;
            this.RunnerId = runnerId;
            this.RunnerName = runnerName;
            this.StartedAt = startedAt;
            this.HeadBranch = headBranch;
            this.WorkflowName = workflowName;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowJobInProgressWorkflowJobVariant2" /> class.
        /// </summary>
        public WebhookWorkflowJobInProgressWorkflowJobVariant2()
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
        public static global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2?>(serializer.Deserialize<global::G.WebhookWorkflowJobInProgressWorkflowJobVariant2>(jsonReader));
        }

    }
}