//HintName: G.Models.InputAudioBufferClearPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to clear the audio bytes in the buffer.
    /// </summary>
    public sealed partial class InputAudioBufferClearPayload
    {
        /// <summary>
        /// Optional client-generated ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputAudioBufferClearPayloadType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferClearPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        public InputAudioBufferClearPayload(
            string? eventId,
            global::G.InputAudioBufferClearPayloadType type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferClearPayload" /> class.
        /// </summary>
        public InputAudioBufferClearPayload()
        {
        }
    }
}