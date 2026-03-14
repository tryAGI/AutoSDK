//HintName: G.Models.UpdateAgentScheduleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for updating an existing agent schedule. All fields are optional for PATCH semantics.
    /// </summary>
    public sealed partial class UpdateAgentScheduleRequest
    {
        /// <summary>
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </summary>
        /// <example>Daily Summary Report</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated description of the schedule's purpose.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Updated input message to send to the agent on each scheduled execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::System.Collections.Generic.IList<global::G.AgentInput>? Message { get; set; }

        /// <summary>
        /// Configuration for when and how often the schedule should execute.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schedule")]
        public global::G.ScheduleConfiguration? Schedule { get; set; }

        /// <summary>
        /// Updated enabled status for the schedule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Updated metadata to include in each session created by this schedule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_metadata")]
        public object? SessionMetadata { get; set; }

        /// <summary>
        /// Updated maximum number of past execution records to keep.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_executions_to_keep")]
        public int? MaxExecutionsToKeep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentScheduleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of an agent schedule.<br/>
        /// Example: Daily Summary Report
        /// </param>
        /// <param name="description">
        /// Updated description of the schedule's purpose.
        /// </param>
        /// <param name="message">
        /// Updated input message to send to the agent on each scheduled execution.
        /// </param>
        /// <param name="schedule">
        /// Configuration for when and how often the schedule should execute.
        /// </param>
        /// <param name="enabled">
        /// Updated enabled status for the schedule.
        /// </param>
        /// <param name="sessionMetadata">
        /// Updated metadata to include in each session created by this schedule.
        /// </param>
        /// <param name="maxExecutionsToKeep">
        /// Updated maximum number of past execution records to keep.
        /// </param>
        public UpdateAgentScheduleRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<global::G.AgentInput>? message,
            global::G.ScheduleConfiguration? schedule,
            bool? enabled,
            object? sessionMetadata,
            int? maxExecutionsToKeep)
        {
            this.Name = name;
            this.Description = description;
            this.Message = message;
            this.Schedule = schedule;
            this.Enabled = enabled;
            this.SessionMetadata = sessionMetadata;
            this.MaxExecutionsToKeep = maxExecutionsToKeep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentScheduleRequest" /> class.
        /// </summary>
        public UpdateAgentScheduleRequest()
        {
        }
    }
}