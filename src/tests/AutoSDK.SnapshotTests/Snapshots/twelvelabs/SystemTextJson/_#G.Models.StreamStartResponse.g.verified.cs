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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StreamStartResponseEventTypeJsonConverter))]
        public global::G.StreamStartResponseEventType EventType { get; set; }

        /// <summary>
        /// An object containing metadata about the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.StreamStartResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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