//HintName: G.Models.CorpusLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorpusLimits
    {
        /// <summary>
        /// The number of documents contained in the corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_docs")]
        public long? UsedDocs { get; set; }

        /// <summary>
        /// The number of document parts contained in the corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_parts")]
        public long? UsedParts { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system.<br/>
        /// The number of bytes contained in the corpus. This includes the document metadata,<br/>
        /// document part metadata, and document contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_bytes")]
        public long? UsedBytes { get; set; }

        /// <summary>
        /// The number of characters contained in the corpus. This includes the document metadata,<br/>
        /// document part metadata, and document contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_characters")]
        public long? UsedCharacters { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system.<br/>
        /// The maximum number of bytes the corpus can be.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_bytes")]
        public long? MaxBytes { get; set; }

        /// <summary>
        /// The maximum size that metadata can be on documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_metadata_bytes")]
        public long? MaxMetadataBytes { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system.<br/>
        /// The maximum per-second addition of new documents to corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_rate")]
        public long? IndexRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusLimits" /> class.
        /// </summary>
        /// <param name="usedDocs">
        /// The number of documents contained in the corpus.
        /// </param>
        /// <param name="usedParts">
        /// The number of document parts contained in the corpus.
        /// </param>
        /// <param name="usedBytes">
        /// NOTE: This field is currently not populated by the system.<br/>
        /// The number of bytes contained in the corpus. This includes the document metadata,<br/>
        /// document part metadata, and document contents.
        /// </param>
        /// <param name="usedCharacters">
        /// The number of characters contained in the corpus. This includes the document metadata,<br/>
        /// document part metadata, and document contents.
        /// </param>
        /// <param name="maxBytes">
        /// NOTE: This field is currently not populated by the system.<br/>
        /// The maximum number of bytes the corpus can be.
        /// </param>
        /// <param name="maxMetadataBytes">
        /// The maximum size that metadata can be on documents.
        /// </param>
        /// <param name="indexRate">
        /// NOTE: This field is currently not populated by the system.<br/>
        /// The maximum per-second addition of new documents to corpus.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorpusLimits(
            long? usedDocs,
            long? usedParts,
            long? usedBytes,
            long? usedCharacters,
            long? maxBytes,
            long? maxMetadataBytes,
            long? indexRate)
        {
            this.UsedDocs = usedDocs;
            this.UsedParts = usedParts;
            this.UsedBytes = usedBytes;
            this.UsedCharacters = usedCharacters;
            this.MaxBytes = maxBytes;
            this.MaxMetadataBytes = maxMetadataBytes;
            this.IndexRate = indexRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusLimits" /> class.
        /// </summary>
        public CorpusLimits()
        {
        }
    }
}