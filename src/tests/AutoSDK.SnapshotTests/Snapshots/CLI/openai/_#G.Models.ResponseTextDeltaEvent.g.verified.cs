//HintName: G.Models.ResponseTextDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is an additional text delta.
    /// </summary>
    public sealed partial class ResponseTextDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.output_text.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseTextDeltaEventTypeJsonConverter))]
        public global::G.ResponseTextDeltaEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the text delta was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the text delta was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The index of the content part that the text delta was added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The text delta that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The sequence number for this event.
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
        /// Initializes a new instance of the <see cref="ResponseTextDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.output_text.delta`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the text delta was added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the text delta was added to.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that the text delta was added to.
        /// </param>
        /// <param name="delta">
        /// The text delta that was added.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTextDeltaEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            string delta,
            int sequenceNumber,
            global::G.ResponseTextDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextDeltaEvent" /> class.
        /// </summary>
        public ResponseTextDeltaEvent()
        {
        }
    }
}