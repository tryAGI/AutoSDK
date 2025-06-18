//HintName: G.Models.ResponseReasoningSummaryDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the reasoning summary content is finalized for an item.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryDoneEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.reasoning_summary.done'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseReasoningSummaryDoneEventTypeJsonConverter))]
        public global::G.ResponseReasoningSummaryDoneEventType Type { get; set; }

        /// <summary>
        /// The unique identifier of the item for which the reasoning summary is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the summary part within the output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SummaryIndex { get; set; }

        /// <summary>
        /// The finalized reasoning summary text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.reasoning_summary.done'.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the item for which the reasoning summary is finalized.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="summaryIndex">
        /// The index of the summary part within the output item.
        /// </param>
        /// <param name="text">
        /// The finalized reasoning summary text.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningSummaryDoneEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            string text,
            int sequenceNumber,
            global::G.ResponseReasoningSummaryDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryDoneEvent" /> class.
        /// </summary>
        public ResponseReasoningSummaryDoneEvent()
        {
        }
    }
}