//HintName: G.Models.StreamStartResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the beginning of the stream.
    /// </summary>
    public sealed partial class StreamStartResponse
    {
        /// <summary>
        /// This field is always set to `stream_start` for this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public global::G.StreamStartResponseEventType EventType { get; set; }

        /// <summary>
        /// An object containing metadata about the stream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.StreamStartResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamStartResponse" /> class.
        /// </summary>
        /// <param name="eventType">
        /// This field is always set to `stream_start` for this event.
        /// </param>
        /// <param name="metadata">
        /// An object containing metadata about the stream.
        /// </param>
        public StreamStartResponse(
            global::G.StreamStartResponseEventType eventType,
            global::G.StreamStartResponseMetadata? metadata)
        {
            this.EventType = eventType;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamStartResponse" /> class.
        /// </summary>
        public StreamStartResponse()
        {
        }
    }
}