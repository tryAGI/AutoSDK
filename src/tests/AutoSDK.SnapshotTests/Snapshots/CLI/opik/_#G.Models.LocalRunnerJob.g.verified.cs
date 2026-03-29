//HintName: G.Models.LocalRunnerJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunnerJob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_id")]
        public global::System.Guid? RunnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LocalRunnerJobStatusJsonConverter))]
        public global::G.LocalRunnerJobStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::G.JsonNode? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.JsonNode? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_id")]
        public global::System.Guid? MaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.LocalRunnerJobMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJob" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="runnerId"></param>
        /// <param name="agentName"></param>
        /// <param name="status"></param>
        /// <param name="inputs"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="maskId"></param>
        /// <param name="metadata"></param>
        /// <param name="timeout"></param>
        /// <param name="createdAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocalRunnerJob(
            global::System.Guid? id,
            global::System.Guid? runnerId,
            string? agentName,
            global::G.LocalRunnerJobStatus? status,
            global::G.JsonNode? inputs,
            global::G.JsonNode? result,
            string? error,
            global::System.Guid? projectId,
            global::System.Guid? traceId,
            global::System.Guid? maskId,
            global::G.LocalRunnerJobMetadata? metadata,
            int? timeout,
            global::System.DateTime? createdAt,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt)
        {
            this.Id = id;
            this.RunnerId = runnerId;
            this.AgentName = agentName;
            this.Status = status;
            this.Inputs = inputs;
            this.Result = result;
            this.Error = error;
            this.ProjectId = projectId;
            this.TraceId = traceId;
            this.MaskId = maskId;
            this.Metadata = metadata;
            this.Timeout = timeout;
            this.CreatedAt = createdAt;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunnerJob" /> class.
        /// </summary>
        public LocalRunnerJob()
        {
        }
    }
}