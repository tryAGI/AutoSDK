//HintName: G.Models.ConversationItemInputAudioTranscriptionFailedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when input audio transcription fails.
    /// </summary>
    public sealed partial class ConversationItemInputAudioTranscriptionFailedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ConversationItemInputAudioTranscriptionFailedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the user message item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the content part containing the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// Details of an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.ErrorDetails? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemInputAudioTranscriptionFailedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="itemId">
        /// The ID of the user message item.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part containing the audio.
        /// </param>
        /// <param name="error">
        /// Details of an error.
        /// </param>
        public ConversationItemInputAudioTranscriptionFailedPayload(
            string eventId,
            global::G.ConversationItemInputAudioTranscriptionFailedPayloadType type,
            string? itemId,
            int? contentIndex,
            global::G.ErrorDetails? error)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ItemId = itemId;
            this.ContentIndex = contentIndex;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemInputAudioTranscriptionFailedPayload" /> class.
        /// </summary>
        public ConversationItemInputAudioTranscriptionFailedPayload()
        {
        }
    }
}