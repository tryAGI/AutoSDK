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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseReasoningSummaryPartAddedEventTypeJsonConverter))]
        public global::G.ResponseReasoningSummaryPartAddedEventType Type { get; set; }

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
        /// The summary part that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseReasoningSummaryPartAddedEventPart Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="part">
        /// The summary part that was added.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningSummaryPartAddedEvent(
            string itemId,
            int outputIndex,
            int summaryIndex,
            global::G.ResponseReasoningSummaryPartAddedEventPart part,
            global::G.ResponseReasoningSummaryPartAddedEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SummaryIndex = summaryIndex;
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