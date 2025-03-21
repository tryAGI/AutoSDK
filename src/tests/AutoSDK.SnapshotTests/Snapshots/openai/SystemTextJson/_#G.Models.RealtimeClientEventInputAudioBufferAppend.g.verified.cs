//HintName: G.Models.RealtimeClientEventInputAudioBufferAppend.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to append audio bytes to the input audio buffer. The audio <br/>
    /// buffer is temporary storage you can write to and later commit. In Server VAD <br/>
    /// mode, the audio buffer is used to detect speech and the server will decide <br/>
    /// when to commit. When Server VAD is disabled, you must commit the audio buffer<br/>
    /// manually.<br/>
    /// The client may choose how much audio to place in each event up to a maximum <br/>
    /// of 15 MiB, for example streaming smaller chunks from the client may allow the <br/>
    /// VAD to be more responsive. Unlike made other client events, the server will <br/>
    /// not send a confirmation response to this event.
    /// </summary>
    public sealed partial class RealtimeClientEventInputAudioBufferAppend
    {
        /// <summary>
        /// Base64-encoded audio bytes. This must be in the format specified by the <br/>
        /// `input_audio_format` field in the session configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.append`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeClientEventInputAudioBufferAppendTypeJsonConverter))]
        public global::G.RealtimeClientEventInputAudioBufferAppendType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventInputAudioBufferAppend" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio bytes. This must be in the format specified by the <br/>
        /// `input_audio_format` field in the session configuration.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.append`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventInputAudioBufferAppend(
            string audio,
            string? eventId,
            global::G.RealtimeClientEventInputAudioBufferAppendType type)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventInputAudioBufferAppend" /> class.
        /// </summary>
        public RealtimeClientEventInputAudioBufferAppend()
        {
        }
    }
}