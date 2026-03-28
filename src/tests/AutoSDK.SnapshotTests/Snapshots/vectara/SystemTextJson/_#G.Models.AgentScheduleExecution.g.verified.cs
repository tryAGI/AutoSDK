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
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScheduleKey { get; set; }

        /// <summary>
        /// Temporal run ID grouping all retry attempts of the same trigger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowRunId { get; set; }

        /// <summary>
        /// Session created by this attempt. Null if the attempt failed before session creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_key")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// 1-based attempt number within the workflow run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Attempt { get; set; }

        /// <summary>
        /// Outcome of this attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentScheduleExecutionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentScheduleExecutionStatus Status { get; set; }

        /// <summary>
        /// Error message if the attempt failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Timestamp when this attempt ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExecutedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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