//HintName: G.Models.ResponseInputTextContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A text input to the model.
    /// </summary>
    public sealed partial class ResponseInputTextContent
    {
        /// <summary>
        /// The type of the input item. Always `input_text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseInputTextContentTypeJsonConverter))]
        public global::G.ResponseInputTextContentType Type { get; set; }

        /// <summary>
        /// The text input to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputTextContent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text input to the model.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_text`.
        /// </param>
        public ResponseInputTextContent(
            string text,
            global::G.ResponseInputTextContentType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInputTextContent" /> class.
        /// </summary>
        public ResponseInputTextContent()
        {
        }
    }
}