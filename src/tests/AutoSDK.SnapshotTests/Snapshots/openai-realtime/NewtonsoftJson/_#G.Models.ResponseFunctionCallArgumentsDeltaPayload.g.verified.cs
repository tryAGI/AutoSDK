//HintName: G.Models.ResponseFunctionCallArgumentsDeltaPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the model-generated function call arguments are updated.
    /// </summary>
    public sealed partial class ResponseFunctionCallArgumentsDeltaPayload
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseFunctionCallArgumentsDeltaPayloadTypeJsonConverter))]
        public global::G.ResponseFunctionCallArgumentsDeltaPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The ID of the function call item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the output item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// The ID of the function call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The arguments delta as a JSON string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDeltaPayload" /> class.
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
        /// The ID of the function call item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item.
        /// </param>
        /// <param name="callId">
        /// The ID of the function call.
        /// </param>
        /// <param name="delta">
        /// The arguments delta as a JSON string.
        /// </param>
        public ResponseFunctionCallArgumentsDeltaPayload(
            string eventId,
            global::G.ResponseFunctionCallArgumentsDeltaPayloadType type,
            string? responseId,
            string? itemId,
            int? outputIndex,
            string? callId,
            string? delta)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.CallId = callId;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDeltaPayload" /> class.
        /// </summary>
        public ResponseFunctionCallArgumentsDeltaPayload()
        {
        }
    }
}