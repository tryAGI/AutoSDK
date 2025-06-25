//HintName: G.Models.UltravoxV1CorpusDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single complete source of information included in a corpus. In the most<br/>
    ///  straight-forward case, this could be an uploaded PDF or a single webpage.<br/>
    ///  However, documents can also be created from other documents during processing,<br/>
    ///  for example turning an HTML page into a markdown document.
    /// </summary>
    public sealed partial class UltravoxV1CorpusDocument
    {
        /// <summary>
        /// The id of the corpus in which this document is included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpusId")]
        public string? CorpusId { get; set; }

        /// <summary>
        /// The id of the source that provides this document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceId")]
        public string? SourceId { get; set; }

        /// <summary>
        /// The unique ID of this document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentId")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// When this document was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The MIME type of the document.<br/>
        ///  https://developer.mozilla.org/en-US/docs/Web/HTTP/MIME_types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Metadata about the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.UltravoxV1CorpusDocumentMetadata? Metadata { get; set; }

        /// <summary>
        /// The size of the document contents, in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public string? SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusDocument" /> class.
        /// </summary>
        /// <param name="corpusId">
        /// The id of the corpus in which this document is included.
        /// </param>
        /// <param name="sourceId">
        /// The id of the source that provides this document.
        /// </param>
        /// <param name="documentId">
        /// The unique ID of this document.
        /// </param>
        /// <param name="created">
        /// When this document was created.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the document.<br/>
        ///  https://developer.mozilla.org/en-US/docs/Web/HTTP/MIME_types
        /// </param>
        /// <param name="metadata">
        /// Metadata about the document.
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the document contents, in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CorpusDocument(
            string? corpusId,
            string? sourceId,
            string? documentId,
            global::System.DateTime? created,
            string? mimeType,
            global::G.UltravoxV1CorpusDocumentMetadata? metadata,
            string? sizeBytes)
        {
            this.CorpusId = corpusId;
            this.SourceId = sourceId;
            this.DocumentId = documentId;
            this.Created = created;
            this.MimeType = mimeType;
            this.Metadata = metadata;
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusDocument" /> class.
        /// </summary>
        public UltravoxV1CorpusDocument()
        {
        }
    }
}