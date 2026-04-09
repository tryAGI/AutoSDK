//HintName: G.Models.ResponseOutputAudioDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio output completed.
    /// </summary>
    public sealed partial class ResponseOutputAudioDoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputAudioDoneEventTypeJsonConverter))]
        public global::G.ResponseOutputAudioDoneEventType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputAudioDoneEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="responseId"></param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="contentIndex"></param>
        public ResponseOutputAudioDoneEvent(
            global::G.ResponseOutputAudioDoneEventType? type,
            string? eventId,
            string? responseId,
            string? itemId,
            int? outputIndex,
            int? contentIndex)
        {
            this.Type = type;
            this.EventId = eventId;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputAudioDoneEvent" /> class.
        /// </summary>
        public ResponseOutputAudioDoneEvent()
        {
        }
    }
}