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
        /// Milliseconds from the start of all audio written to the buffer during the <br/>
        /// session when speech was first detected. This will correspond to the <br/>
        /// beginning of audio sent to the model, and thus includes the <br/>
        /// `prefix_padding_ms` configured in the Session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_start_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int AudioStartMs { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The ID of the user message item that will be created when speech stops.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `input_audio_buffer.speech_started`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventInputAudioBufferSpeechStartedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferSpeechStarted" /> class.
        /// </summary>
        /// <param name="audioStartMs">
        /// Milliseconds from the start of all audio written to the buffer during the <br/>
        /// session when speech was first detected. This will correspond to the <br/>
        /// beginning of audio sent to the model, and thus includes the <br/>
        /// `prefix_padding_ms` configured in the Session.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created when speech stops.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.speech_started`.
        /// </param>
        public RealtimeServerEventInputAudioBufferSpeechStarted(
            int audioStartMs,
            string eventId,
            string itemId,
            global::G.RealtimeServerEventInputAudioBufferSpeechStartedType type)
        {
            this.AudioStartMs = audioStartMs;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
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