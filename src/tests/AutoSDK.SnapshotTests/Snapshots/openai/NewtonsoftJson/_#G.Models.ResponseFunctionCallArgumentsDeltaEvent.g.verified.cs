//HintName: G.Models.ResponseFunctionCallArgumentsDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a partial function-call arguments delta.
    /// </summary>
    public sealed partial class ResponseFunctionCallArgumentsDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.function_call_arguments.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFunctionCallArgumentsDeltaEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the function-call arguments delta is added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the function-call arguments delta is added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// The function-call arguments delta that is added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.function_call_arguments.delta`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the function-call arguments delta is added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the function-call arguments delta is added to.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="delta">
        /// The function-call arguments delta that is added.
        /// </param>
        public ResponseFunctionCallArgumentsDeltaEvent(
            string itemId,
            int outputIndex,
            int sequenceNumber,
            string delta,
            global::G.ResponseFunctionCallArgumentsDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDeltaEvent" /> class.
        /// </summary>
        public ResponseFunctionCallArgumentsDeltaEvent()
        {
        }
    }
}