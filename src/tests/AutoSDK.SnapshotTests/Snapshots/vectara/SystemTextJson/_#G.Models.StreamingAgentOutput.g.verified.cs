//HintName: G.Models.StreamingAgentOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A streaming chunk of agent output (SSE only, not stored).
    /// </summary>
    public sealed partial class StreamingAgentOutput
    {
        /// <summary>
        /// The type of streaming event.<br/>
        /// Default Value: streaming_agent_output<br/>
        /// Example: streaming_agent_output
        /// </summary>
        /// <default>"streaming_agent_output"</default>
        /// <example>streaming_agent_output</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "streaming_agent_output";

        /// <summary>
        /// The text chunk content.<br/>
        /// Example: Hello, I can help you with
        /// </summary>
        /// <example>Hello, I can help you with</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

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
        /// Initializes a new instance of the <see cref="StreamingAgentOutput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of streaming event.<br/>
        /// Default Value: streaming_agent_output<br/>
        /// Example: streaming_agent_output
        /// </param>
        /// <param name="content">
        /// The text chunk content.<br/>
        /// Example: Hello, I can help you with
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamingAgentOutput(
            string type,
            string content,
            global::System.DateTime createdAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAgentOutput" /> class.
        /// </summary>
        public StreamingAgentOutput()
        {
        }
    }
}