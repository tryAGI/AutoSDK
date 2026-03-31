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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseInputTextContentTypeJsonConverter))]
        public global::G.ResponseInputTextContentType Type { get; set; }

        /// <summary>
        /// The text input to the model.
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
        /// Initializes a new instance of the <see cref="ResponseInputTextContent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text input to the model.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_text`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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