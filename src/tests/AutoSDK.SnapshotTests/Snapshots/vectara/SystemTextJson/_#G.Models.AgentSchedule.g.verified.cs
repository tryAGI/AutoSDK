//HintName: G.Models.AgentSchedule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An agent schedule that automates agent execution at specified intervals.
    /// </summary>
    public sealed partial class AgentSchedule
    {
        /// <summary>
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </summary>
        /// <example>daily-report</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentKey { get; set; }

        /// <summary>
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </summary>
        /// <example>Daily Summary Report</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A detailed description of the schedule's purpose.<br/>
        /// Example: Generates a daily summary report of customer support activities
        /// </summary>
        /// <example>Generates a daily summary report of customer support activities</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The input message to send to the agent on each scheduled execution.<br/>
        /// Example: [{"type":"text","content":"Generate a summary of today\u0027s activities"}]
        /// </summary>
        /// <example>[{"type":"text","content":"Generate a summary of today\u0027s activities"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentInput> Message { get; set; }

        /// <summary>
        /// Configuration for when and how often the schedule should execute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScheduleConfigurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScheduleConfiguration Schedule { get; set; }

        /// <summary>
        /// Whether the schedule is currently active and executing.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Arbitrary metadata to include in each session created by this schedule.<br/>
        /// Default Value: {}<br/>
        /// Example: {"report_type":"daily","format":"markdown"}
        /// </summary>
        /// <example>{"report_type":"daily","format":"markdown"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_metadata")]
        public object? SessionMetadata { get; set; }

        /// <summary>
        /// Maximum number of past execution records to keep. Older records are deleted automatically when a new execution is recorded.<br/>
        /// Default Value: 10<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_executions_to_keep")]
        public int? MaxExecutionsToKeep { get; set; }

        /// <summary>
        /// Timestamp of the most recent execution. Tracked by Temporal and updated automatically<br/>
        /// after each execution. Null if the schedule has never executed.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_execution_at")]
        public global::System.DateTime? LastExecutionAt { get; set; }

        /// <summary>
        /// Timestamp when the schedule was created. Note: This is a placeholder value as Temporal<br/>
        /// does not store creation timestamps. Use for API compatibility only.<br/>
        /// Example: 1970-01-01T00:00:00Z
        /// </summary>
        /// <example>1970-01-01T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSchedule" /> class.
        /// </summary>
        /// <param name="key">
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </param>
        /// <param name="description">
        /// A detailed description of the schedule's purpose.<br/>
        /// Example: Generates a daily summary report of customer support activities
        /// </param>
        /// <param name="message">
        /// The input message to send to the agent on each scheduled execution.<br/>
        /// Example: [{"type":"text","content":"Generate a summary of today\u0027s activities"}]
        /// </param>
        /// <param name="schedule">
        /// Configuration for when and how often the schedule should execute.
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule is currently active and executing.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="sessionMetadata">
        /// Arbitrary metadata to include in each session created by this schedule.<br/>
        /// Default Value: {}<br/>
        /// Example: {"report_type":"daily","format":"markdown"}
        /// </param>
        /// <param name="maxExecutionsToKeep">
        /// Maximum number of past execution records to keep. Older records are deleted automatically when a new execution is recorded.<br/>
        /// Default Value: 10<br/>
        /// Example: 10
        /// </param>
        /// <param name="lastExecutionAt">
        /// Timestamp of the most recent execution. Tracked by Temporal and updated automatically<br/>
        /// after each execution. Null if the schedule has never executed.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the schedule was created. Note: This is a placeholder value as Temporal<br/>
        /// does not store creation timestamps. Use for API compatibility only.<br/>
        /// Example: 1970-01-01T00:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSchedule(
            string key,
            string agentKey,
            string name,
            global::System.Collections.Generic.IList<global::G.AgentInput> message,
            global::G.ScheduleConfiguration schedule,
            bool enabled,
            global::System.DateTime createdAt,
            string? description,
            object? sessionMetadata,
            int? maxExecutionsToKeep,
            global::System.DateTime? lastExecutionAt)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.AgentKey = agentKey ?? throw new global::System.ArgumentNullException(nameof(agentKey));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Schedule = schedule;
            this.Enabled = enabled;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.SessionMetadata = sessionMetadata;
            this.MaxExecutionsToKeep = maxExecutionsToKeep;
            this.LastExecutionAt = lastExecutionAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSchedule" /> class.
        /// </summary>
        public AgentSchedule()
        {
        }
    }
}