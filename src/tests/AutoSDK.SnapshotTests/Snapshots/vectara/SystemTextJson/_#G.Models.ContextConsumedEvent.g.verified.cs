//HintName: G.Models.ContextConsumedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Token usage event reporting context window consumption.
    /// </summary>
    public sealed partial class ContextConsumedEvent
    {
        /// <summary>
        /// The event type.<br/>
        /// Default Value: context_consumed<br/>
        /// Example: context_consumed
        /// </summary>
        /// <default>"context_consumed"</default>
        /// <example>context_consumed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "context_consumed";

        /// <summary>
        /// Token usage statistics for a session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_context_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SessionContextUsage SessionContextUsage { get; set; }

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
        /// Initializes a new instance of the <see cref="ContextConsumedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The event type.<br/>
        /// Default Value: context_consumed<br/>
        /// Example: context_consumed
        /// </param>
        /// <param name="sessionContextUsage">
        /// Token usage statistics for a session.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created.<br/>
        /// Example: 2024-01-15T10:35:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextConsumedEvent(
            string type,
            global::G.SessionContextUsage sessionContextUsage,
            global::System.DateTime createdAt)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SessionContextUsage = sessionContextUsage ?? throw new global::System.ArgumentNullException(nameof(sessionContextUsage));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextConsumedEvent" /> class.
        /// </summary>
        public ContextConsumedEvent()
        {
        }
    }
}