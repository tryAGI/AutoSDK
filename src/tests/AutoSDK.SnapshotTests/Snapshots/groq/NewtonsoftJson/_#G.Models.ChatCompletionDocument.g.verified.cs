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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The source of the document. Only text and JSON sources are currently supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionDocumentSource Source { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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