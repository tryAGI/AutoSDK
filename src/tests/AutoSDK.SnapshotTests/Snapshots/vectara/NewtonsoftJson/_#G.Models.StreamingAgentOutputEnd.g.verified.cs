//HintName: G.Models.StreamingAgentOutputEnd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Signals the end of streaming agent output (SSE only, not stored).
    /// </summary>
    public sealed partial class StreamingAgentOutputEnd
    {
        /// <summary>
        /// The type of streaming event.<br/>
        /// Default Value: streaming_agent_output_end<br/>
        /// Example: streaming_agent_output_end
        /// </summary>
        /// <default>"streaming_agent_output_end"</default>
        /// <example>streaming_agent_output_end</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The ID of the persisted AgentOutputEvent.<br/>
        /// Example: aev_user_001
        /// </summary>
        /// <example>aev_user_001</example>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAgentOutputEnd" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of streaming event.<br/>
        /// Default Value: streaming_agent_output_end<br/>
        /// Example: streaming_agent_output_end
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        /// <param name="eventId">
        /// The ID of the persisted AgentOutputEvent.<br/>
        /// Example: aev_user_001
        /// </param>
        public StreamingAgentOutputEnd(
            string type,
            global::System.DateTime createdAt,
            string? eventId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.EventId = eventId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAgentOutputEnd" /> class.
        /// </summary>
        public StreamingAgentOutputEnd()
        {
        }
    }
}