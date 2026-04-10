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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.KnowledgeBaseSourceDocumentTypeJsonConverter))]
        public global::G.KnowledgeBaseSourceDocumentType Type { get; set; }

        /// <summary>
        /// Unique id of the knowledge base source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceId { get; set; } = default!;

        /// <summary>
        /// Filename of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// URL of the document stored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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