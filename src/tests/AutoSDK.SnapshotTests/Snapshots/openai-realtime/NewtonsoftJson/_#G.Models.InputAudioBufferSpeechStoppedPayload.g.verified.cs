//HintName: G.Models.InputAudioBufferSpeechStoppedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when speech stops in server VAD mode.
    /// </summary>
    public sealed partial class InputAudioBufferSpeechStoppedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputAudioBufferSpeechStoppedPayloadType Type { get; set; }

        /// <summary>
        /// Milliseconds since the session started when speech stopped.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_end_ms")]
        public int? AudioEndMs { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferSpeechStoppedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="audioEndMs">
        /// Milliseconds since the session started when speech stopped.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created.
        /// </param>
        public InputAudioBufferSpeechStoppedPayload(
            string eventId,
            global::G.InputAudioBufferSpeechStoppedPayloadType type,
            int? audioEndMs,
            string? itemId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.AudioEndMs = audioEndMs;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferSpeechStoppedPayload" /> class.
        /// </summary>
        public InputAudioBufferSpeechStoppedPayload()
        {
        }
    }
}