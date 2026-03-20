//HintName: G.Models.InputAudioTranscriptionCompletedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio transcription has been completed.
    /// </summary>
    public sealed partial class InputAudioTranscriptionCompletedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InputAudioTranscriptionCompletedEventTypeJsonConverter))]
        public global::G.InputAudioTranscriptionCompletedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioTranscriptionCompletedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="itemId"></param>
        /// <param name="transcript"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudioTranscriptionCompletedEvent(
            global::G.InputAudioTranscriptionCompletedEventType? type,
            string? eventId,
            string? itemId,
            string? transcript)
        {
            this.Type = type;
            this.EventId = eventId;
            this.ItemId = itemId;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioTranscriptionCompletedEvent" /> class.
        /// </summary>
        public InputAudioTranscriptionCompletedEvent()
        {
        }
    }
}