//HintName: G.Models.ResponseReasoningDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the reasoning content is finalized for an item.
    /// </summary>
    public sealed partial class ResponseReasoningDoneEvent
    {
        /// <summary>
        /// The type of the event. Always 'response.reasoning.done'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseReasoningDoneEventType Type { get; set; }

        /// <summary>
        /// The unique identifier of the item for which reasoning is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response's output array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the reasoning content part within the output item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The finalized reasoning text.
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
        /// Initializes a new instance of the <see cref="ResponseReasoningDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always 'response.reasoning.done'.
        /// </param>
        /// <param name="itemId">
        /// The unique identifier of the item for which reasoning is finalized.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response's output array.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the reasoning content part within the output item.
        /// </param>
        /// <param name="text">
        /// The finalized reasoning text.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseReasoningDoneEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            string text,
            int sequenceNumber,
            global::G.ResponseReasoningDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningDoneEvent" /> class.
        /// </summary>
        public ResponseReasoningDoneEvent()
        {
        }
    }
}