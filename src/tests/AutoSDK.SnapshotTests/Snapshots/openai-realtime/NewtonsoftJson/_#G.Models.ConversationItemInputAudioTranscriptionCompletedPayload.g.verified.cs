//HintName: G.Models.ConversationItemInputAudioTranscriptionCompletedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when input audio transcription succeeds.
    /// </summary>
    public sealed partial class ConversationItemInputAudioTranscriptionCompletedPayload
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
        public global::G.ConversationItemInputAudioTranscriptionCompletedPayloadType Type { get; set; }

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
        /// The transcribed text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemInputAudioTranscriptionCompletedPayload" /> class.
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
        /// <param name="transcript">
        /// The transcribed text.
        /// </param>
        public ConversationItemInputAudioTranscriptionCompletedPayload(
            string eventId,
            global::G.ConversationItemInputAudioTranscriptionCompletedPayloadType type,
            string? itemId,
            int? contentIndex,
            string? transcript)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ItemId = itemId;
            this.ContentIndex = contentIndex;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemInputAudioTranscriptionCompletedPayload" /> class.
        /// </summary>
        public ConversationItemInputAudioTranscriptionCompletedPayload()
        {
        }
    }
}