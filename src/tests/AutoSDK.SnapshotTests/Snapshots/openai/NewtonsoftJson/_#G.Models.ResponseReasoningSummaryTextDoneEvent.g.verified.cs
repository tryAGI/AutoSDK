//HintName: G.Models.ResponseReasoningSummaryTextDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a reasoning summary text is completed.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryTextDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.reasoning_summary_text.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseReasoningSummaryTextDoneEventType Type { get; set; }

        /// <summary>
        /// The ID of the item this summary text is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item this summary text is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the summary part within the reasoning summary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int SummaryIndex { get; set; } = default!;

        /// <summary>
        /// The full text of the completed reasoning summary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryTextDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.reasoning_summary_text.done`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item this summary text is associated with.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item this summary text is associated with.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary part within the reasoning summary.
        /// </param>
        /// <param name="text">
        /// The full text of the completed reasoning summary.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseReasoningSummaryTextDoneEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            string text,
            int sequenceNumber,
            global::G.ResponseReasoningSummaryTextDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryTextDoneEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryTextDoneEvent()
        {
        }
    }
}