//HintName: G.Models.StreamingThinking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A streaming chunk of agent thinking (SSE only, not stored).
    /// </summary>
    public sealed partial class StreamingThinking
    {
        /// <summary>
        /// The type of streaming event.<br/>
        /// Default Value: streaming_thinking<br/>
        /// Example: streaming_thinking
        /// </summary>
        /// <default>"streaming_thinking"</default>
        /// <example>streaming_thinking</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The thinking chunk content.<br/>
        /// Example: Let me think about this step
        /// </summary>
        /// <example>Let me think about this step</example>
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
        /// Initializes a new instance of the <see cref="StreamingThinking" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of streaming event.<br/>
        /// Default Value: streaming_thinking<br/>
        /// Example: streaming_thinking
        /// </param>
        /// <param name="content">
        /// The thinking chunk content.<br/>
        /// Example: Let me think about this step
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        public StreamingThinking(
            string type,
            string content,
            global::System.DateTime createdAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingThinking" /> class.
        /// </summary>
        public StreamingThinking()
        {
        }
    }
}