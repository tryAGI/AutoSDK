//HintName: G.Models.ResponseReasoningSummaryDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a delta (partial update) to the reasoning summary content.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.reasoning_summary.delta'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseReasoningSummaryDeltaEventType Type { get; set; }

        /// <summary>
        /// The unique identifier of the item for which the reasoning summary is being updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the summary part within the output item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int SummaryIndex { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// The partial update to the reasoning summary content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public object Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.reasoning_summary.delta'.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the item for which the reasoning summary is being updated.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary part within the output item.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="delta">
        /// The partial update to the reasoning summary content.
        /// </param>
        public ResponseReasoningSummaryDeltaEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            int sequenceNumber,
            object delta,
            global::G.ResponseReasoningSummaryDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.SequenceNumber = sequenceNumber;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryDeltaEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryDeltaEvent()
        {
        }
    }
}