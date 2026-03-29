//HintName: G.Models.Run.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a run - a conversation or processing session for an agent. Runs track when agents process messages and maintain the relationship between agents, steps, and messages.
    /// </summary>
    public sealed partial class Run
    {
        /// <summary>
        /// The human-friendly ID of the Run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The current status of the run.<br/>
        /// Default Value: created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.RunStatus? Status { get; set; }

        /// <summary>
        /// The timestamp when the run was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the run was completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The unique identifier of the agent associated with the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the conversation associated with the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// The base template ID that the run belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_template_id")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// Whether the run was created in background mode.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// Additional metadata for the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The request configuration for the run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_config")]
        public global::G.LettaRequestConfig? RequestConfig { get; set; }

        /// <summary>
        /// The reason why the run was stopped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_reason")]
        public global::G.StopReasonType? StopReason { get; set; }

        /// <summary>
        /// If set, POST to this URL when the run completes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Timestamp when the callback was last attempted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_sent_at")]
        public global::System.DateTime? CallbackSentAt { get; set; }

        /// <summary>
        /// HTTP status code returned by the callback endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_status_code")]
        public int? CallbackStatusCode { get; set; }

        /// <summary>
        /// Optional error message from attempting to POST the callback endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_error")]
        public string? CallbackError { get; set; }

        /// <summary>
        /// Time to first token for a run in nanoseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttft_ns")]
        public long? TtftNs { get; set; }

        /// <summary>
        /// Total run duration in nanoseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_duration_ns")]
        public long? TotalDurationNs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The unique identifier of the agent associated with the run.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Run
        /// </param>
        /// <param name="status">
        /// The current status of the run.<br/>
        /// Default Value: created
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the run was created.
        /// </param>
        /// <param name="completedAt">
        /// The timestamp when the run was completed.
        /// </param>
        /// <param name="conversationId">
        /// The unique identifier of the conversation associated with the run.
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template ID that the run belongs to.
        /// </param>
        /// <param name="background">
        /// Whether the run was created in background mode.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the run.
        /// </param>
        /// <param name="requestConfig">
        /// The request configuration for the run.
        /// </param>
        /// <param name="stopReason">
        /// The reason why the run was stopped.
        /// </param>
        /// <param name="callbackUrl">
        /// If set, POST to this URL when the run completes.
        /// </param>
        /// <param name="callbackSentAt">
        /// Timestamp when the callback was last attempted.
        /// </param>
        /// <param name="callbackStatusCode">
        /// HTTP status code returned by the callback endpoint.
        /// </param>
        /// <param name="callbackError">
        /// Optional error message from attempting to POST the callback endpoint.
        /// </param>
        /// <param name="ttftNs">
        /// Time to first token for a run in nanoseconds
        /// </param>
        /// <param name="totalDurationNs">
        /// Total run duration in nanoseconds
        /// </param>
        public Run(
            string agentId,
            string? id,
            global::G.RunStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? conversationId,
            string? baseTemplateId,
            bool? background,
            object? metadata,
            global::G.LettaRequestConfig? requestConfig,
            global::G.StopReasonType? stopReason,
            string? callbackUrl,
            global::System.DateTime? callbackSentAt,
            int? callbackStatusCode,
            string? callbackError,
            long? ttftNs,
            long? totalDurationNs)
        {
            this.Id = id;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationId = conversationId;
            this.BaseTemplateId = baseTemplateId;
            this.Background = background;
            this.Metadata = metadata;
            this.RequestConfig = requestConfig;
            this.StopReason = stopReason;
            this.CallbackUrl = callbackUrl;
            this.CallbackSentAt = callbackSentAt;
            this.CallbackStatusCode = callbackStatusCode;
            this.CallbackError = callbackError;
            this.TtftNs = ttftNs;
            this.TotalDurationNs = totalDurationNs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        public Run()
        {
        }
    }
}