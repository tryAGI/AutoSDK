//HintName: G.Models.ChatCompletionDocumentSourceText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document whose contents are provided inline as text.
    /// </summary>
    public sealed partial class ChatCompletionDocumentSourceText
    {
        /// <summary>
        /// Identifies this document source as inline text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionDocumentSourceTextTypeJsonConverter))]
        public global::G.ChatCompletionDocumentSourceTextType Type { get; set; }

        /// <summary>
        /// The document contents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDocumentSourceText" /> class.
        /// </summary>
        /// <param name="text">
        /// The document contents.
        /// </param>
        /// <param name="type">
        /// Identifies this document source as inline text.
        /// </param>
        public ChatCompletionDocumentSourceText(
            string text,
            global::G.ChatCompletionDocumentSourceTextType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDocumentSourceText" /> class.
        /// </summary>
        public ChatCompletionDocumentSourceText()
        {
        }
    }
}