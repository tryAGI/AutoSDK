//HintName: G.Models.ResponseTextDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when text content is finalized.
    /// </summary>
    public sealed partial class ResponseTextDoneEvent
    {
        /// <summary>
        /// The index of the content part that the text content is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The ID of the output item that the text content is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the text content is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The text content that is finalized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `response.output_text.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseTextDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextDoneEvent" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part that the text content is finalized.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the text content is finalized.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the text content is finalized.
        /// </param>
        /// <param name="text">
        /// The text content that is finalized.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.output_text.done`.
        /// </param>
        public ResponseTextDoneEvent(
            int contentIndex,
            string itemId,
            int outputIndex,
            string text,
            global::G.ResponseTextDoneEventType type)
        {
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextDoneEvent" /> class.
        /// </summary>
        public ResponseTextDoneEvent()
        {
        }
    }
}