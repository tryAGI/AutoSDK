//HintName: G.Models.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This event is the output of audio transcription for user audio written to the <br/>
    /// user audio buffer. Transcription begins when the input audio buffer is <br/>
    /// committed by the client or server (in `server_vad` mode). Transcription runs <br/>
    /// asynchronously with Response creation, so this event may come before or after <br/>
    /// the Response events.<br/>
    /// Realtime API models accept audio natively, and thus input transcription is a <br/>
    /// separate process run on a separate ASR (Automatic Speech Recognition) model, <br/>
    /// currently always `whisper-1`. Thus the transcript may diverge somewhat from <br/>
    /// the model's interpretation, and should be treated as a rough guide.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemInputAudioTranscriptionCompleted
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be<br/>
        /// `conversation.item.input_audio_transcription.completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedTypeJsonConverter))]
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType Type { get; set; }

        /// <summary>
        /// The ID of the user message item containing the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the content part containing the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionCompleted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be<br/>
        /// `conversation.item.input_audio_transcription.completed`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item containing the audio.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part containing the audio.
        /// </param>
        /// <param name="transcript">
        /// The transcribed text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationItemInputAudioTranscriptionCompleted(
            string eventId,
            string itemId,
            int contentIndex,
            string transcript,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ContentIndex = contentIndex;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionCompleted" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemInputAudioTranscriptionCompleted()
        {
        }
    }
}