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
        /// The function-call arguments delta that is added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

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
        /// The type of the event. Always `response.function_call_arguments.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseFunctionCallArgumentsDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// The function-call arguments delta that is added.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the function-call arguments delta is added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the function-call arguments delta is added to.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.function_call_arguments.delta`.
        /// </param>
        public ResponseFunctionCallArgumentsDeltaEvent(
            string delta,
            string itemId,
            int outputIndex,
            global::G.ResponseFunctionCallArgumentsDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
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