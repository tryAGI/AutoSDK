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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "streaming_thinking_end";

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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