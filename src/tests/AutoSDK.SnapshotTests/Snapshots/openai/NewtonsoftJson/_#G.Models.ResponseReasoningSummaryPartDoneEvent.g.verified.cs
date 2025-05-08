//HintName: G.Models.ResponseReasoningSummaryPartDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a reasoning summary part is completed.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryPartDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.reasoning_summary_part.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseReasoningSummaryPartDoneEventType Type { get; set; }

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
        /// The completed summary part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseReasoningSummaryPartDoneEventPart Part { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.reasoning_summary_part.done`.
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
        /// <param name="part">
        /// The completed summary part.
        /// </param>
        public ResponseReasoningSummaryPartDoneEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            global::G.ResponseReasoningSummaryPartDoneEventPart part,
            global::G.ResponseReasoningSummaryPartDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Part = part ?? throw new global::System.ArgumentNullException(nameof(part));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartDoneEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryPartDoneEvent()
        {
        }
    }
}