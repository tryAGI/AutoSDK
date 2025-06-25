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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseReasoningSummaryDeltaEventTypeJsonConverter))]
        public global::G.ResponseReasoningSummaryDeltaEventType Type { get; set; }

        /// <summary>
        /// The unique identifier of the item for which the reasoning summary is being updated.
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
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The partial update to the reasoning summary content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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