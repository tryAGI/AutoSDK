//HintName: G.Models.ResponseReasoningDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a delta (partial update) to the reasoning content.
    /// </summary>
    public sealed partial class ResponseReasoningDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.reasoning.delta'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseReasoningDeltaEventType Type { get; set; }

        /// <summary>
        /// The unique identifier of the item for which reasoning is being updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the reasoning content part within the output item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The partial update to the reasoning content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public object Delta { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.reasoning.delta'.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the item for which reasoning is being updated.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the reasoning content part within the output item.
        /// </param>
        /// <param name="delta">
        /// The partial update to the reasoning content.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseReasoningDeltaEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            object delta,
            int sequenceNumber,
            global::G.ResponseReasoningDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningDeltaEvent" /> class.
        /// </summary>
        public ResponseReasoningDeltaEvent()
        {
        }
    }
}