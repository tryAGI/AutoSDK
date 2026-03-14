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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "streaming_agent_output_end";

        /// <summary>
        /// The ID of the persisted AgentOutputEvent.<br/>
        /// Example: aev_user_001
        /// </summary>
        /// <example>aev_user_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </summary>
        /// <example>2024-01-15T10:35:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAgentOutputEnd" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of streaming event.<br/>
        /// Default Value: streaming_agent_output_end<br/>
        /// Example: streaming_agent_output_end
        /// </param>
        /// <param name="eventId">
        /// The ID of the persisted AgentOutputEvent.<br/>
        /// Example: aev_user_001
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamingAgentOutputEnd(
            string type,
            global::System.DateTime createdAt,
            string? eventId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CreatedAt = createdAt;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAgentOutputEnd" /> class.
        /// </summary>
        public StreamingAgentOutputEnd()
        {
        }
    }
}