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
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioEndMs { get; set; }

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the user message item that will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.speech_stopped`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventInputAudioBufferSpeechStoppedTypeJsonConverter))]
        public global::G.RealtimeServerEventInputAudioBufferSpeechStoppedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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