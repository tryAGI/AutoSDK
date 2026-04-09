//HintName: G.Models.ResponseOutputAudioTranscriptDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio transcript completed.
    /// </summary>
    public sealed partial class ResponseOutputAudioTranscriptDoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputAudioTranscriptDoneEventTypeJsonConverter))]
        public global::G.ResponseOutputAudioTranscriptDoneEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index")]
        public int? ContentIndex { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseOutputAudioTranscriptDoneEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="responseId"></param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="contentIndex"></param>
        /// <param name="transcript"></param>
        public ResponseOutputAudioTranscriptDoneEvent(
            global::G.ResponseOutputAudioTranscriptDoneEventType? type,
            string? eventId,
            string? responseId,
            string? itemId,
            int? outputIndex,
            int? contentIndex,
            string? transcript)
        {
            this.Type = type;
            this.EventId = eventId;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputAudioTranscriptDoneEvent" /> class.
        /// </summary>
        public ResponseOutputAudioTranscriptDoneEvent()
        {
        }
    }
}