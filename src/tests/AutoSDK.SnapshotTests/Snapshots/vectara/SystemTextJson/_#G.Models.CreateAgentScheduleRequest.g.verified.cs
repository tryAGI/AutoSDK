//HintName: G.Models.CreateAgentScheduleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for creating a new agent schedule.
    /// </summary>
    public sealed partial class CreateAgentScheduleRequest
    {
        /// <summary>
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </summary>
        /// <example>daily-report</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </summary>
        /// <example>Daily Summary Report</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional detailed description of the schedule's purpose.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The input message to send to the agent on each scheduled execution.
        /// </summary>
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
        /// Whether the schedule should be active upon creation.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Arbitrary metadata to include in each session created by this schedule.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_metadata")]
        public object? SessionMetadata { get; set; }

        /// <summary>
        /// Maximum number of past execution records to keep. Defaults to 10.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_executions_to_keep")]
        public int? MaxExecutionsToKeep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentScheduleRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// A unique key that identifies an agent schedule. Uses "key" terminology (instead of "id")<br/>
        /// for consistency with other Vectara API resources (AgentKey, SessionKey, CorpusKey, etc.).<br/>
        /// Example: daily-report
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </param>
        /// <param name="description">
        /// Optional detailed description of the schedule's purpose.
        /// </param>
        /// <param name="message">
        /// The input message to send to the agent on each scheduled execution.
        /// </param>
        /// <param name="schedule">
        /// Configuration for when and how often the schedule should execute.
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule should be active upon creation.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sessionMetadata">
        /// Arbitrary metadata to include in each session created by this schedule.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="maxExecutionsToKeep">
        /// Maximum number of past execution records to keep. Defaults to 10.<br/>
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentScheduleRequest(
            string name,
            global::System.Collections.Generic.IList<global::G.AgentInput> message,
            global::G.ScheduleConfiguration schedule,
            string? key,
            string? description,
            bool? enabled,
            object? sessionMetadata,
            int? maxExecutionsToKeep)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Schedule = schedule;
            this.Key = key;
            this.Description = description;
            this.Enabled = enabled;
            this.SessionMetadata = sessionMetadata;
            this.MaxExecutionsToKeep = maxExecutionsToKeep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentScheduleRequest" /> class.
        /// </summary>
        public CreateAgentScheduleRequest()
        {
        }
    }
}