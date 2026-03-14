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
        /// The number of documents contained in the corpus.<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::Newtonsoft.Json.JsonProperty("used_docs")]
        public long? UsedDocs { get; set; }

        /// <summary>
        /// The number of document parts contained in the corpus.<br/>
        /// Example: 3748
        /// </summary>
        /// <example>3748</example>
        [global::Newtonsoft.Json.JsonProperty("used_parts")]
        public long? UsedParts { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system. The number of bytes contained in the corpus. This includes the document metadata, document part metadata, and document contents.<br/>
        /// Example: 795790
        /// </summary>
        /// <example>795790</example>
        [global::Newtonsoft.Json.JsonProperty("used_bytes")]
        public long? UsedBytes { get; set; }

        /// <summary>
        /// The number of characters contained in the corpus. This includes the document metadata, document part metadata, and document contents.<br/>
        /// Example: 1839847
        /// </summary>
        /// <example>1839847</example>
        [global::Newtonsoft.Json.JsonProperty("used_characters")]
        public long? UsedCharacters { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system. The maximum number of bytes the corpus can be.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_bytes")]
        public long? MaxBytes { get; set; }

        /// <summary>
        /// The maximum size that metadata can be on documents.<br/>
        /// Example: 10485760
        /// </summary>
        /// <example>10485760</example>
        [global::Newtonsoft.Json.JsonProperty("max_metadata_bytes")]
        public long? MaxMetadataBytes { get; set; }

        /// <summary>
        /// NOTE: This field is currently not populated by the system. The maximum per-second addition of new documents to corpus.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_rate")]
        public long? IndexRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusLimits" /> class.
        /// </summary>
        /// <param name="usedDocs">
        /// The number of documents contained in the corpus.<br/>
        /// Example: 8
        /// </param>
        /// <param name="usedParts">
        /// The number of document parts contained in the corpus.<br/>
        /// Example: 3748
        /// </param>
        /// <param name="usedBytes">
        /// NOTE: This field is currently not populated by the system. The number of bytes contained in the corpus. This includes the document metadata, document part metadata, and document contents.<br/>
        /// Example: 795790
        /// </param>
        /// <param name="usedCharacters">
        /// The number of characters contained in the corpus. This includes the document metadata, document part metadata, and document contents.<br/>
        /// Example: 1839847
        /// </param>
        /// <param name="maxBytes">
        /// NOTE: This field is currently not populated by the system. The maximum number of bytes the corpus can be.
        /// </param>
        /// <param name="maxMetadataBytes">
        /// The maximum size that metadata can be on documents.<br/>
        /// Example: 10485760
        /// </param>
        /// <param name="indexRate">
        /// NOTE: This field is currently not populated by the system. The maximum per-second addition of new documents to corpus.
        /// </param>
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