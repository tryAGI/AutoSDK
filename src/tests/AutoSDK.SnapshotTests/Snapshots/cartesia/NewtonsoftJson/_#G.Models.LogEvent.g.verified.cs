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
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// Additional metadata associated with the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; } = default!;

        /// <summary>
        /// The timestamp when the event was received relative to the start of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public double Timestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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