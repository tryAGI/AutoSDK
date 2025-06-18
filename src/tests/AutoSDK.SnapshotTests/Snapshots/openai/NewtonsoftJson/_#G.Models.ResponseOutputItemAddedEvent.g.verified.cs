//HintName: G.Models.ResponseOutputItemAddedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a new output item is added.
    /// </summary>
    public sealed partial class ResponseOutputItemAddedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.output_item.added`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseOutputItemAddedEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OutputItem Item { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemAddedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.output_item.added`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that was added.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="item"></param>
        public ResponseOutputItemAddedEvent(
            int outputIndex,
            int sequenceNumber,
            global::G.OutputItem item,
            global::G.ResponseOutputItemAddedEventType type)
        {
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Item = item;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemAddedEvent" /> class.
        /// </summary>
        public ResponseOutputItemAddedEvent()
        {
        }
    }
}