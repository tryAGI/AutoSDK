//HintName: G.Models.RealtimeServerEventInputAudioBufferSpeechStarted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sent by the server when in `server_vad` mode to indicate that speech has been <br/>
    /// detected in the audio buffer. This can happen any time audio is added to the <br/>
    /// buffer (unless speech is already detected). The client may want to use this <br/>
    /// event to interrupt audio playback or provide visual feedback to the user. <br/>
    /// The client should expect to receive a `input_audio_buffer.speech_stopped` event <br/>
    /// when speech stops. The `item_id` property is the ID of the user message item <br/>
    /// that will be created when speech stops and will also be included in the <br/>
    /// `input_audio_buffer.speech_stopped` event (unless the client manually commits <br/>
    /// the audio buffer during VAD activation).
    /// </summary>
    public sealed partial class RealtimeServerEventInputAudioBufferSpeechStarted
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.speech_started`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStartedTypeJsonConverter))]
        public global::G.RealtimeServerEventInputAudioBufferSpeechStartedType Type { get; set; }

        /// <summary>
        /// Milliseconds from the start of all audio written to the buffer during the <br/>
        /// session when speech was first detected. This will correspond to the <br/>
        /// beginning of audio sent to the model, and thus includes the <br/>
        /// `prefix_padding_ms` configured in the Session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioStartMs { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created when speech stops.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferSpeechStarted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.speech_started`.
        /// </param>
        /// <param name="audioStartMs">
        /// Milliseconds from the start of all audio written to the buffer during the <br/>
        /// session when speech was first detected. This will correspond to the <br/>
        /// beginning of audio sent to the model, and thus includes the <br/>
        /// `prefix_padding_ms` configured in the Session.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created when speech stops.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventInputAudioBufferSpeechStarted(
            string eventId,
            int audioStartMs,
            string itemId,
            global::G.RealtimeServerEventInputAudioBufferSpeechStartedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.AudioStartMs = audioStartMs;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferSpeechStarted" /> class.
        /// </summary>
        public RealtimeServerEventInputAudioBufferSpeechStarted()
        {
        }
    }
}