//HintName: G.Models.ResponseReasoningSummaryTextDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a delta is added to a reasoning summary text.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryTextDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.reasoning_summary_text.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseReasoningSummaryTextDeltaEventType Type { get; set; }

        /// <summary>
        /// The ID of the item this summary text delta is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item this summary text delta is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the summary part within the reasoning summary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int SummaryIndex { get; set; } = default!;

        /// <summary>
        /// The text delta that was added to the summary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryTextDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.reasoning_summary_text.delta`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item this summary text delta is associated with.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item this summary text delta is associated with.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary part within the reasoning summary.
        /// </param>
        /// <param name="delta">
        /// The text delta that was added to the summary.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseReasoningSummaryTextDeltaEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            string delta,
            int sequenceNumber,
            global::G.ResponseReasoningSummaryTextDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryTextDeltaEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryTextDeltaEvent()
        {
        }
    }
}