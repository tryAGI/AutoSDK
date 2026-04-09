//HintName: G.Models.InputAudioBufferSpeechStartedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when speech is detected in server VAD mode.
    /// </summary>
    public sealed partial class InputAudioBufferSpeechStartedPayload
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferSpeechStartedPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferSpeechStartedPayloadType Type { get; set; }

        /// <summary>
        /// Milliseconds since the session started when speech was detected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_start_ms")]
        public int? AudioStartMs { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created when speech stops.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferSpeechStartedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="audioStartMs">
        /// Milliseconds since the session started when speech was detected.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created when speech stops.
        /// </param>
        public InputAudioBufferSpeechStartedPayload(
            string eventId,
            global::G.InputAudioBufferSpeechStartedPayloadType type,
            int? audioStartMs,
            string? itemId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.AudioStartMs = audioStartMs;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferSpeechStartedPayload" /> class.
        /// </summary>
        public InputAudioBufferSpeechStartedPayload()
        {
        }
    }
}