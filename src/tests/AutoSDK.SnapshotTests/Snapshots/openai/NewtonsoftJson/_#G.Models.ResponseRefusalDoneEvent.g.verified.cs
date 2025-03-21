//HintName: G.Models.ResponseRefusalDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when refusal text is finalized.
    /// </summary>
    public sealed partial class ResponseRefusalDoneEvent
    {
        /// <summary>
        /// The index of the content part that the refusal text is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the output item that the refusal text is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the refusal text is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The refusal text that is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal", Required = global::Newtonsoft.Json.Required.Always)]
        public string Refusal { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `response.refusal.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseRefusalDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRefusalDoneEvent" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part that the refusal text is finalized.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the refusal text is finalized.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the refusal text is finalized.
        /// </param>
        /// <param name="refusal">
        /// The refusal text that is finalized.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.refusal.done`.
        /// </param>
        public ResponseRefusalDoneEvent(
            int contentIndex,
            string itemId,
            int outputIndex,
            string refusal,
            global::G.ResponseRefusalDoneEventType type)
        {
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRefusalDoneEvent" /> class.
        /// </summary>
        public ResponseRefusalDoneEvent()
        {
        }
    }
}