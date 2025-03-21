//HintName: G.Models.RealtimeServerEventInputAudioBufferSpeechStopped.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned in `server_vad` mode when the server detects the end of speech in <br/>
    /// the audio buffer. The server will also send an `conversation.item.created` <br/>
    /// event with the user message item that is created from the audio buffer.
    /// </summary>
    public sealed partial class RealtimeServerEventInputAudioBufferSpeechStopped
    {
        /// <summary>
        /// Milliseconds since the session started when speech stopped. This will <br/>
        /// correspond to the end of audio sent to the model, and thus includes the <br/>
        /// `min_silence_duration_ms` configured in the Session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_end_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int AudioEndMs { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The ID of the user message item that will be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `input_audio_buffer.speech_stopped`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventInputAudioBufferSpeechStoppedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferSpeechStopped" /> class.
        /// </summary>
        /// <param name="audioEndMs">
        /// Milliseconds since the session started when speech stopped. This will <br/>
        /// correspond to the end of audio sent to the model, and thus includes the <br/>
        /// `min_silence_duration_ms` configured in the Session.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item that will be created.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.speech_stopped`.
        /// </param>
        public RealtimeServerEventInputAudioBufferSpeechStopped(
            int audioEndMs,
            string eventId,
            string itemId,
            global::G.RealtimeServerEventInputAudioBufferSpeechStoppedType type)
        {
            this.AudioEndMs = audioEndMs;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventInputAudioBufferSpeechStopped" /> class.
        /// </summary>
        public RealtimeServerEventInputAudioBufferSpeechStopped()
        {
        }
    }
}