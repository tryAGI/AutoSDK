//HintName: G.Models.StreamingThinkingEnd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Signals the end of streaming thinking (SSE only, not stored).
    /// </summary>
    public sealed partial class StreamingThinkingEnd
    {
        /// <summary>
        /// The type of streaming event.<br/>
        /// Default Value: streaming_thinking_end<br/>
        /// Example: streaming_thinking_end
        /// </summary>
        /// <default>"streaming_thinking_end"</default>
        /// <example>streaming_thinking_end</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="StreamingThinkingEnd" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of streaming event.<br/>
        /// Default Value: streaming_thinking_end<br/>
        /// Example: streaming_thinking_end
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
        public StreamingThinkingEnd(
            string type,
            global::System.DateTime createdAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingThinkingEnd" /> class.
        /// </summary>
        public StreamingThinkingEnd()
        {
        }
    }
}