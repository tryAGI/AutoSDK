//HintName: G.Models.RealtimeServerEventConversationItemInputAudioTranscriptionFailed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when input audio transcription is configured, and a transcription <br/>
    /// request for a user message failed. These events are separate from other <br/>
    /// `error` events so that the client can identify the related Item.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemInputAudioTranscriptionFailed
    {
        /// <summary>
        /// The index of the content part containing the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// Details of the transcription error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError Error { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The ID of the user message item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The event type, must be<br/>
        /// `conversation.item.input_audio_transcription.failed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionFailed" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part containing the audio.
        /// </param>
        /// <param name="error">
        /// Details of the transcription error.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item.
        /// </param>
        /// <param name="type">
        /// The event type, must be<br/>
        /// `conversation.item.input_audio_transcription.failed`.
        /// </param>
        public RealtimeServerEventConversationItemInputAudioTranscriptionFailed(
            int contentIndex,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError error,
            string eventId,
            string itemId,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionFailedType type)
        {
            this.ContentIndex = contentIndex;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionFailed" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemInputAudioTranscriptionFailed()
        {
        }
    }
}