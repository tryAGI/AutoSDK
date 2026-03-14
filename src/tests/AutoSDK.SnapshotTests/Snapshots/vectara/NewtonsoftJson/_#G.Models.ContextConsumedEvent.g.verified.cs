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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Token usage statistics for a session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_context_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SessionContextUsage SessionContextUsage { get; set; } = default!;

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