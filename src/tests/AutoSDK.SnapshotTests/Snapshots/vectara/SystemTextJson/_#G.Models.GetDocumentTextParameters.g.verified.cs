//HintName: G.Models.GetDocumentTextParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configurable parameters for the get document text tool. If not overridden, they will be required by the LLM to fill in.
    /// </summary>
    public sealed partial class GetDocumentTextParameters
    {
        /// <summary>
        /// The document ID of the document to fetch text from.<br/>
        /// Example: doc_12345
        /// </summary>
        /// <example>doc_12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// The corpus key containing the document.<br/>
        /// Example: my-corpus
        /// </summary>
        /// <example>my-corpus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextParameters" /> class.
        /// </summary>
        /// <param name="documentId">
        /// The document ID of the document to fetch text from.<br/>
        /// Example: doc_12345
        /// </param>
        /// <param name="corpusKey">
        /// The corpus key containing the document.<br/>
        /// Example: my-corpus
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentTextParameters(
            string? documentId,
            string? corpusKey)
        {
            this.DocumentId = documentId;
            this.CorpusKey = corpusKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextParameters" /> class.
        /// </summary>
        public GetDocumentTextParameters()
        {
        }
    }
}