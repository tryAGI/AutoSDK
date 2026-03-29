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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runner_id")]
        public global::System.Guid? RunnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.LocalRunnerJobStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::G.JsonNode? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.JsonNode? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_id")]
        public global::System.Guid? MaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.LocalRunnerJobMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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