//HintName: G.Models.LogEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogEvent
    {
        /// <summary>
        /// The event name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// Additional metadata associated with the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The timestamp when the event was received relative to the start of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogEvent" /> class.
        /// </summary>
        /// <param name="event">
        /// The event name.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the event.
        /// </param>
        /// <param name="timestamp">
        /// The timestamp when the event was received relative to the start of the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogEvent(
            string @event,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            double timestamp)
        {
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogEvent" /> class.
        /// </summary>
        public LogEvent()
        {
        }
    }
}