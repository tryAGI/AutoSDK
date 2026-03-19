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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemInputAudioTranscriptionFailedPayloadTypeJsonConverter))]
        public global::G.ConversationItemInputAudioTranscriptionFailedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the user message item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the content part containing the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// Details of an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.ErrorDetails? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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