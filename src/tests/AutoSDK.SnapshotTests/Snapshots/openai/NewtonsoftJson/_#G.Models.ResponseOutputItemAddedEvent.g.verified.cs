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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OutputItem Item { get; set; } = default!;

        /// <summary>
        /// The index of the output item that was added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `response.output_item.added`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseOutputItemAddedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemAddedEvent" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="outputIndex">
        /// The index of the output item that was added.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.output_item.added`.
        /// </param>
        public ResponseOutputItemAddedEvent(
            global::G.OutputItem item,
            int outputIndex,
            global::G.ResponseOutputItemAddedEventType type)
        {
            this.Item = item;
            this.OutputIndex = outputIndex;
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