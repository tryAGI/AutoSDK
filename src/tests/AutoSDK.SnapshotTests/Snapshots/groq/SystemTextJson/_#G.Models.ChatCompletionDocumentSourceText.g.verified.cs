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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionDocumentSourceTextTypeJsonConverter))]
        public global::G.ChatCompletionDocumentSourceTextType Type { get; set; }

        /// <summary>
        /// The document contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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