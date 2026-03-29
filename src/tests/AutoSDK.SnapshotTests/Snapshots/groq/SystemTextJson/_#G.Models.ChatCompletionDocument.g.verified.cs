//HintName: G.Models.ChatCompletionDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document that can be referenced by the model while generating responses.
    /// </summary>
    public sealed partial class ChatCompletionDocument
    {
        /// <summary>
        /// Optional unique identifier that can be used for citations in responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The source of the document. Only text and JSON sources are currently supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionDocumentSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatCompletionDocumentSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDocument" /> class.
        /// </summary>
        /// <param name="source">
        /// The source of the document. Only text and JSON sources are currently supported.
        /// </param>
        /// <param name="id">
        /// Optional unique identifier that can be used for citations in responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionDocument(
            global::G.ChatCompletionDocumentSource source,
            string? id)
        {
            this.Id = id;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionDocument" /> class.
        /// </summary>
        public ChatCompletionDocument()
        {
        }
    }
}