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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The text chunk content.<br/>
        /// Example: Hello, I can help you with
        /// </summary>
        /// <example>Hello, I can help you with</example>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

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