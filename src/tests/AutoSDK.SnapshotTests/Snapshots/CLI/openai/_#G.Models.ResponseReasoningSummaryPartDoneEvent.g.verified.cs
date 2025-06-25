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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseReasoningSummaryPartDoneEventTypeJsonConverter))]
        public global::G.ResponseReasoningSummaryPartDoneEventType Type { get; set; }

        /// <summary>
        /// The ID of the item this summary part is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item this summary part is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the summary part within the reasoning summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SummaryIndex { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The completed summary part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseReasoningSummaryPartDoneEventPart Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="part">
        /// The completed summary part.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningSummaryPartDoneEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            int sequenceNumber,
            global::G.ResponseReasoningSummaryPartDoneEventPart part,
            global::G.ResponseReasoningSummaryPartDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.SequenceNumber = sequenceNumber;
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