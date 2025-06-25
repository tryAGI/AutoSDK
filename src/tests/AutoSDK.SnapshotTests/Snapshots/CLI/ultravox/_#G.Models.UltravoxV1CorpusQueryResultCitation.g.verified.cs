//HintName: G.Models.UltravoxV1CorpusQueryResultCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation for a query result.
    /// </summary>
    public sealed partial class UltravoxV1CorpusQueryResultCitation
    {
        /// <summary>
        /// The source that provided the document from which this chunk was retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceId")]
        public string? SourceId { get; set; }

        /// <summary>
        /// The document from which this chunk was retrieved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentId")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// The public URL of the document, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicUrl")]
        public string? PublicUrl { get; set; }

        /// <summary>
        /// The title of the document, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusQueryResultCitation" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// The source that provided the document from which this chunk was retrieved.
        /// </param>
        /// <param name="documentId">
        /// The document from which this chunk was retrieved.
        /// </param>
        /// <param name="publicUrl">
        /// The public URL of the document, if any.
        /// </param>
        /// <param name="title">
        /// The title of the document, if known.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CorpusQueryResultCitation(
            string? sourceId,
            string? documentId,
            string? publicUrl,
            string? title)
        {
            this.SourceId = sourceId;
            this.DocumentId = documentId;
            this.PublicUrl = publicUrl;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusQueryResultCitation" /> class.
        /// </summary>
        public UltravoxV1CorpusQueryResultCitation()
        {
        }
    }
}