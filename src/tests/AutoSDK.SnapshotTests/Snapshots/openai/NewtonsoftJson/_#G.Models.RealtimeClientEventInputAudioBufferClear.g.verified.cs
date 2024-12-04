//HintName: G.Models.RealtimeClientEventInputAudioBufferClear.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to clear the audio bytes in the buffer. The server will <br/>
    /// respond with an `input_audio_buffer.cleared` event.
    /// </summary>
    public sealed partial class RealtimeClientEventInputAudioBufferClear
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.clear`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeClientEventInputAudioBufferClearType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventInputAudioBufferClear" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.clear`.
        /// </param>
        public RealtimeClientEventInputAudioBufferClear(
            string? eventId,
            global::G.RealtimeClientEventInputAudioBufferClearType type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventInputAudioBufferClear" /> class.
        /// </summary>
        public RealtimeClientEventInputAudioBufferClear()
        {
        }
    }
}