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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputAudioTranscriptionCompletedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioTranscriptionCompletedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="itemId"></param>
        /// <param name="transcript"></param>
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