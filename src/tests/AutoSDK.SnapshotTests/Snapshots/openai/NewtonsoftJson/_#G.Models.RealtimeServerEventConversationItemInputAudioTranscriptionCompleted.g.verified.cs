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
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be<br/>
        /// `conversation.item.input_audio_transcription.completed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType Type { get; set; }

        /// <summary>
        /// The ID of the user message item containing the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the content part containing the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// The log probabilities of the transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::System.Collections.Generic.IList<global::G.LogProbProperties>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="logprobs">
        /// The log probabilities of the transcription.
        /// </param>
        public RealtimeServerEventConversationItemInputAudioTranscriptionCompleted(
            string eventId,
            string itemId,
            int contentIndex,
            string transcript,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionCompletedType type,
            global::System.Collections.Generic.IList<global::G.LogProbProperties>? logprobs)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ContentIndex = contentIndex;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Type = type;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionCompleted" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemInputAudioTranscriptionCompleted()
        {
        }
    }
}