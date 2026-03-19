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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputAudioBufferSpeechStartedPayloadTypeJsonConverter))]
        public global::G.InputAudioBufferSpeechStartedPayloadType Type { get; set; }

        /// <summary>
        /// Milliseconds since the session started when speech was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_ms")]
        public int? AudioStartMs { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created when speech stops.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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