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
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The ID of the output item that the text content is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the text content is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The text content that is finalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the event. Always `response.output_text.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseTextDoneEventTypeJsonConverter))]
        public global::G.ResponseTextDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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