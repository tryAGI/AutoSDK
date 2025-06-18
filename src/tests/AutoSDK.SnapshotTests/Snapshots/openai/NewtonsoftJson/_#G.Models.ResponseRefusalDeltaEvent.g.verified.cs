//HintName: G.Models.ResponseRefusalDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a partial refusal text.
    /// </summary>
    public sealed partial class ResponseRefusalDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.refusal.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseRefusalDeltaEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the refusal text is added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the refusal text is added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The index of the content part that the refusal text is added to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The refusal text that is added.
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
        /// Initializes a new instance of the <see cref="ResponseRefusalDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.refusal.delta`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the refusal text is added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the refusal text is added to.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that the refusal text is added to.
        /// </param>
        /// <param name="delta">
        /// The refusal text that is added.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseRefusalDeltaEvent(
            string itemId,
            int outputIndex,
            int contentIndex,
            string delta,
            int sequenceNumber,
            global::G.ResponseRefusalDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRefusalDeltaEvent" /> class.
        /// </summary>
        public ResponseRefusalDeltaEvent()
        {
        }
    }
}