//HintName: G.Models.ResponseTextDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseTextDoneEvent
    {
        /// <summary>
        /// Index of the content part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ContentIndex { get; set; }

        /// <summary>
        /// ID of the output item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Index of the output item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OutputIndex { get; set; }

        /// <summary>
        /// Complete text content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Event type<br/>
        /// Default Value: response.output_text.done
        /// </summary>
        /// <default>global::G.ResponseTextDoneEventType.ResponseOutputTextDone</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseTextDoneEventTypeJsonConverter))]
        public global::G.ResponseTextDoneEventType Type { get; set; } = global::G.ResponseTextDoneEventType.ResponseOutputTextDone;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextDoneEvent" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// Index of the content part
        /// </param>
        /// <param name="itemId">
        /// ID of the output item
        /// </param>
        /// <param name="outputIndex">
        /// Index of the output item
        /// </param>
        /// <param name="text">
        /// Complete text content
        /// </param>
        /// <param name="type">
        /// Event type<br/>
        /// Default Value: response.output_text.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTextDoneEvent(
            double contentIndex,
            string itemId,
            double outputIndex,
            string text,
            global::G.ResponseTextDoneEventType type = global::G.ResponseTextDoneEventType.ResponseOutputTextDone)
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