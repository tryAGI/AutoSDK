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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "streaming_thinking";

        /// <summary>
        /// The thinking chunk content.<br/>
        /// Example: Let me think about this step
        /// </summary>
        /// <example>Let me think about this step</example>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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