//HintName: G.Models.SourceConfigJson.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON-serializable source configuration for tool configs.<br/>
    /// This can override existing sources or define entirely new ones.<br/>
    /// For new sources, collection_name is required.
    /// </summary>
    public sealed partial class SourceConfigJson
    {
        /// <summary>
        /// Source name (can be existing or new)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// MongoDB database name. Default: eleven_customer_support
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("db_name")]
        public string? DbName { get; set; }

        /// <summary>
        /// MongoDB collection name. Required for new sources.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_name")]
        public string? CollectionName { get; set; }

        /// <summary>
        /// Number of chunks from vector search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("k_dense")]
        public int? KDense { get; set; }

        /// <summary>
        /// Number of chunks from BM25 search
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("k_keyword")]
        public int? KKeyword { get; set; }

        /// <summary>
        /// Weight for vector results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dense_weight")]
        public double? DenseWeight { get; set; }

        /// <summary>
        /// Weight for BM25 results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyword_weight")]
        public double? KeywordWeight { get; set; }

        /// <summary>
        /// Weight for cross-source merging
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_weight")]
        public double? SourceWeight { get; set; }

        /// <summary>
        /// Vector search index name. Default: 'default'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_index_name")]
        public string? VectorIndexName { get; set; }

        /// <summary>
        /// Field containing embeddings. Default: 'embedding'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_field")]
        public string? EmbeddingField { get; set; }

        /// <summary>
        /// Field containing text content. Default: 'content'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_field")]
        public string? ContentField { get; set; }

        /// <summary>
        /// Whether this source is active<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceConfigJson" /> class.
        /// </summary>
        /// <param name="name">
        /// Source name (can be existing or new)
        /// </param>
        /// <param name="dbName">
        /// MongoDB database name. Default: eleven_customer_support
        /// </param>
        /// <param name="collectionName">
        /// MongoDB collection name. Required for new sources.
        /// </param>
        /// <param name="kDense">
        /// Number of chunks from vector search
        /// </param>
        /// <param name="kKeyword">
        /// Number of chunks from BM25 search
        /// </param>
        /// <param name="denseWeight">
        /// Weight for vector results
        /// </param>
        /// <param name="keywordWeight">
        /// Weight for BM25 results
        /// </param>
        /// <param name="sourceWeight">
        /// Weight for cross-source merging
        /// </param>
        /// <param name="vectorIndexName">
        /// Vector search index name. Default: 'default'
        /// </param>
        /// <param name="embeddingField">
        /// Field containing embeddings. Default: 'embedding'
        /// </param>
        /// <param name="contentField">
        /// Field containing text content. Default: 'content'
        /// </param>
        /// <param name="enabled">
        /// Whether this source is active<br/>
        /// Default Value: true
        /// </param>
        public SourceConfigJson(
            string name,
            string? dbName,
            string? collectionName,
            int? kDense,
            int? kKeyword,
            double? denseWeight,
            double? keywordWeight,
            double? sourceWeight,
            string? vectorIndexName,
            string? embeddingField,
            string? contentField,
            bool? enabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DbName = dbName;
            this.CollectionName = collectionName;
            this.KDense = kDense;
            this.KKeyword = kKeyword;
            this.DenseWeight = denseWeight;
            this.KeywordWeight = keywordWeight;
            this.SourceWeight = sourceWeight;
            this.VectorIndexName = vectorIndexName;
            this.EmbeddingField = embeddingField;
            this.ContentField = contentField;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceConfigJson" /> class.
        /// </summary>
        public SourceConfigJson()
        {
        }
    }
}