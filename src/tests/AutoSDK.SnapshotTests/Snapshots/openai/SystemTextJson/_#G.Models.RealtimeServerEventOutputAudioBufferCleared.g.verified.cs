//HintName: G.Models.RealtimeServerEventOutputAudioBufferCleared.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **WebRTC Only:** Emitted when the output audio buffer is cleared. This happens either in VAD<br/>
    /// mode when the user has interrupted (`input_audio_buffer.speech_started`),<br/>
    /// or when the client has emitted the `output_audio_buffer.clear` event to manually<br/>
    /// cut off the current audio response.<br/>
    /// [Learn more](/docs/guides/realtime-model-capabilities#client-and-server-events-for-audio-in-webrtc).
    /// </summary>
    public sealed partial class RealtimeServerEventOutputAudioBufferCleared
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `output_audio_buffer.cleared`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventOutputAudioBufferClearedTypeJsonConverter))]
        public global::G.RealtimeServerEventOutputAudioBufferClearedType Type { get; set; }

        /// <summary>
        /// The unique ID of the response that produced the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventOutputAudioBufferCleared" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `output_audio_buffer.cleared`.
        /// </param>
        /// <param name="responseId">
        /// The unique ID of the response that produced the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventOutputAudioBufferCleared(
            string eventId,
            string responseId,
            global::G.RealtimeServerEventOutputAudioBufferClearedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventOutputAudioBufferCleared" /> class.
        /// </summary>
        public RealtimeServerEventOutputAudioBufferCleared()
        {
        }
    }
}