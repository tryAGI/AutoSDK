//HintName: G.Models.ResponseReasoningSummaryPartAddedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a new reasoning summary part is added.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryPartAddedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.reasoning_summary_part.added`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseReasoningSummaryPartAddedEventType Type { get; set; }

        /// <summary>
        /// The ID of the item this summary part is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item this summary part is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the summary part within the reasoning summary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int SummaryIndex { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// The summary part that was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseReasoningSummaryPartAddedEventPart Part { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartAddedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.reasoning_summary_part.added`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item this summary part is associated with.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item this summary part is associated with.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary part within the reasoning summary.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="part">
        /// The summary part that was added.
        /// </param>
        public ResponseReasoningSummaryPartAddedEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            int sequenceNumber,
            global::G.ResponseReasoningSummaryPartAddedEventPart part,
            global::G.ResponseReasoningSummaryPartAddedEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.SequenceNumber = sequenceNumber;
            this.Part = part ?? throw new global::System.ArgumentNullException(nameof(part));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartAddedEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryPartAddedEvent()
        {
        }
    }
}