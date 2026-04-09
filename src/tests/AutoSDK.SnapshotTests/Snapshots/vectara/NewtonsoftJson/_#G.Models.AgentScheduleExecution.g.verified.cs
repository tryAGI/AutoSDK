//HintName: G.Models.AgentScheduleExecution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single execution attempt of an agent schedule.
    /// </summary>
    public sealed partial class AgentScheduleExecution
    {
        /// <summary>
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </summary>
        /// <example>daily-report</example>
        [global::Newtonsoft.Json.JsonProperty("schedule_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ScheduleKey { get; set; } = default!;

        /// <summary>
        /// Temporal run ID grouping all retry attempts of the same trigger.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowRunId { get; set; } = default!;

        /// <summary>
        /// Session created by this attempt. Null if the attempt failed before session creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_key")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// 1-based attempt number within the workflow run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attempt", Required = global::Newtonsoft.Json.Required.Always)]
        public int Attempt { get; set; } = default!;

        /// <summary>
        /// Outcome of this attempt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentScheduleExecutionStatusJsonConverter))]
        public global::G.AgentScheduleExecutionStatus Status { get; set; } = default!;

        /// <summary>
        /// Error message if the attempt failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Timestamp when this attempt ran.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("executed_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExecutedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleExecution" /> class.
        /// </summary>
        /// <param name="scheduleKey">
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </param>
        /// <param name="workflowRunId">
        /// Temporal run ID grouping all retry attempts of the same trigger.
        /// </param>
        /// <param name="attempt">
        /// 1-based attempt number within the workflow run.
        /// </param>
        /// <param name="status">
        /// Outcome of this attempt.
        /// </param>
        /// <param name="executedAt">
        /// Timestamp when this attempt ran.
        /// </param>
        /// <param name="sessionKey">
        /// Session created by this attempt. Null if the attempt failed before session creation.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the attempt failed.
        /// </param>
        public AgentScheduleExecution(
            string scheduleKey,
            string workflowRunId,
            int attempt,
            global::G.AgentScheduleExecutionStatus status,
            global::System.DateTime executedAt,
            string? sessionKey,
            string? errorMessage)
        {
            this.ScheduleKey = scheduleKey ?? throw new global::System.ArgumentNullException(nameof(scheduleKey));
            this.WorkflowRunId = workflowRunId ?? throw new global::System.ArgumentNullException(nameof(workflowRunId));
            this.SessionKey = sessionKey;
            this.Attempt = attempt;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.ExecutedAt = executedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentScheduleExecution" /> class.
        /// </summary>
        public AgentScheduleExecution()
        {
        }
    }
}