//HintName: G.Models.ResponseOutputItemDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an output item is marked done.
    /// </summary>
    public sealed partial class ResponseOutputItemDoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OutputItem Item { get; set; } = default!;

        /// <summary>
        /// The index of the output item that was marked done.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `response.output_item.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseOutputItemDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemDoneEvent" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="outputIndex">
        /// The index of the output item that was marked done.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.output_item.done`.
        /// </param>
        public ResponseOutputItemDoneEvent(
            global::G.OutputItem item,
            int outputIndex,
            global::G.ResponseOutputItemDoneEventType type)
        {
            this.Item = item;
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemDoneEvent" /> class.
        /// </summary>
        public ResponseOutputItemDoneEvent()
        {
        }
    }
}