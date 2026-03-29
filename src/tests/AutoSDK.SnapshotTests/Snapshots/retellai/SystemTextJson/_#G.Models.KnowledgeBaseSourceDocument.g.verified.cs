//HintName: G.Models.KnowledgeBaseSourceDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseSourceDocument
    {
        /// <summary>
        /// Type of the knowledge base source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseSourceDocumentTypeJsonConverter))]
        public global::G.KnowledgeBaseSourceDocumentType Type { get; set; }

        /// <summary>
        /// Unique id of the knowledge base source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// Filename of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// URL of the document stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSourceDocument" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// Unique id of the knowledge base source.
        /// </param>
        /// <param name="filename">
        /// Filename of the document.
        /// </param>
        /// <param name="fileUrl">
        /// URL of the document stored.
        /// </param>
        /// <param name="type">
        /// Type of the knowledge base source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseSourceDocument(
            string sourceId,
            string filename,
            string fileUrl,
            global::G.KnowledgeBaseSourceDocumentType type)
        {
            this.Type = type;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.FileUrl = fileUrl ?? throw new global::System.ArgumentNullException(nameof(fileUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseSourceDocument" /> class.
        /// </summary>
        public KnowledgeBaseSourceDocument()
        {
        }
    }
}