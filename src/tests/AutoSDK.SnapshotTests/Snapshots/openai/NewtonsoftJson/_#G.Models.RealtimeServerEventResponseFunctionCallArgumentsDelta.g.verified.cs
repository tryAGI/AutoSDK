//HintName: G.Models.RealtimeServerEventResponseFunctionCallArgumentsDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the model-generated function call arguments are updated.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseFunctionCallArgumentsDelta
    {
        /// <summary>
        /// The ID of the function call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// The arguments delta as a JSON string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The ID of the function call item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResponseId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `response.function_call_arguments.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventResponseFunctionCallArgumentsDeltaType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseFunctionCallArgumentsDelta" /> class.
        /// </summary>
        /// <param name="callId">
        /// The ID of the function call.
        /// </param>
        /// <param name="delta">
        /// The arguments delta as a JSON string.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the function call item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.function_call_arguments.delta`.
        /// </param>
        public RealtimeServerEventResponseFunctionCallArgumentsDelta(
            string callId,
            string delta,
            string eventId,
            string itemId,
            int outputIndex,
            string responseId,
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDeltaType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseFunctionCallArgumentsDelta" /> class.
        /// </summary>
        public RealtimeServerEventResponseFunctionCallArgumentsDelta()
        {
        }
    }
}