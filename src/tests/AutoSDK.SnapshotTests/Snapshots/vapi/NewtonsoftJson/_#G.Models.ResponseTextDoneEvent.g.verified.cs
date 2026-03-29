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
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public double ContentIndex { get; set; } = default!;

        /// <summary>
        /// ID of the output item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// Index of the output item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public double OutputIndex { get; set; } = default!;

        /// <summary>
        /// Complete text content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Event type<br/>
        /// Default Value: response.output_text.done
        /// </summary>
        /// <default>global::G.ResponseTextDoneEventType.ResponseOutputTextDone</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseTextDoneEventType Type { get; set; } = global::G.ResponseTextDoneEventType.ResponseOutputTextDone;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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