//HintName: G.Models.ResponseAudioDeltaPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the model-generated audio is updated.
    /// </summary>
    public sealed partial class ResponseAudioDeltaPayload
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseAudioDeltaPayloadTypeJsonConverter))]
        public global::G.ResponseAudioDeltaPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the output item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// The index of the content part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// Base64-encoded audio data delta.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDeltaPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part.
        /// </param>
        /// <param name="delta">
        /// Base64-encoded audio data delta.
        /// </param>
        public ResponseAudioDeltaPayload(
            string eventId,
            global::G.ResponseAudioDeltaPayloadType type,
            string? responseId,
            string? itemId,
            int? outputIndex,
            int? contentIndex,
            string? delta)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDeltaPayload" /> class.
        /// </summary>
        public ResponseAudioDeltaPayload()
        {
        }
    }
}