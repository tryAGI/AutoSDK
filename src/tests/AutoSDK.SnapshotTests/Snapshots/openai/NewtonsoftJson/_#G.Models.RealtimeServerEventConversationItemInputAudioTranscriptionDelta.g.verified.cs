//HintName: G.Models.RealtimeServerEventConversationItemInputAudioTranscriptionDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the text value of an input audio transcription content part is updated.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemInputAudioTranscriptionDelta
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `conversation.item.input_audio_transcription.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType Type { get; set; }

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the content part in the item's content array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// The text delta.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public string? Delta { get; set; }

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
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.input_audio_transcription.delta`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part in the item's content array.
        /// </param>
        /// <param name="delta">
        /// The text delta.
        /// </param>
        /// <param name="logprobs">
        /// The log probabilities of the transcription.
        /// </param>
        public RealtimeServerEventConversationItemInputAudioTranscriptionDelta(
            string eventId,
            string itemId,
            global::G.RealtimeServerEventConversationItemInputAudioTranscriptionDeltaType type,
            int? contentIndex,
            string? delta,
            global::System.Collections.Generic.IList<global::G.LogProbProperties>? logprobs)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
            this.ContentIndex = contentIndex;
            this.Delta = delta;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionDelta" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemInputAudioTranscriptionDelta()
        {
        }
    }
}