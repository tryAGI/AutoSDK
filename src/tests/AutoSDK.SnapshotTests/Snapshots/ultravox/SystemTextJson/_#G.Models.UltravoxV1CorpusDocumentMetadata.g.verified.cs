//HintName: G.Models.UltravoxV1CorpusDocumentMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about a document. This is typically not included in the document's<br/>
    ///  chunks, but can be used for filtering or citations.<br/>
    ///  Derived documents inherit metadata from their source documents in general.
    /// </summary>
    public sealed partial class UltravoxV1CorpusDocumentMetadata
    {
        /// <summary>
        /// The public URL of the document, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// The BCP47 language code of the document, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The title of the document, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A description of the document, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The timestamp that the document was published, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published")]
        public global::System.DateTime? Published { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusDocumentMetadata" /> class.
        /// </summary>
        /// <param name="publicUrl">
        /// The public URL of the document, if any.
        /// </param>
        /// <param name="language">
        /// The BCP47 language code of the document, if known.
        /// </param>
        /// <param name="title">
        /// The title of the document, if known.
        /// </param>
        /// <param name="description">
        /// A description of the document, if known.
        /// </param>
        /// <param name="published">
        /// The timestamp that the document was published, if known.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CorpusDocumentMetadata(
            string? publicUrl,
            string? language,
            string? title,
            string? description,
            global::System.DateTime? published)
        {
            this.PublicUrl = publicUrl;
            this.Language = language;
            this.Title = title;
            this.Description = description;
            this.Published = published;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusDocumentMetadata" /> class.
        /// </summary>
        public UltravoxV1CorpusDocumentMetadata()
        {
        }
    }
}