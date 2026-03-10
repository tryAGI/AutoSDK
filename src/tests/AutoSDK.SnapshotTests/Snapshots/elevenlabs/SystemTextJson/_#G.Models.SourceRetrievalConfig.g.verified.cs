//HintName: G.Models.SourceRetrievalConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceRetrievalConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// Default Value: eleven_customer_support
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_name")]
        public string? DbName { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k_dense")]
        public int? KDense { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k_keyword")]
        public int? KKeyword { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dense_weight")]
        public double? DenseWeight { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword_weight")]
        public double? KeywordWeight { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_weight")]
        public double? SourceWeight { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_index_name")]
        public string? VectorIndexName { get; set; }

        /// <summary>
        /// Default Value: embedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_field")]
        public string? EmbeddingField { get; set; }

        /// <summary>
        /// Default Value: content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_field")]
        public string? ContentField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_field")]
        public string? FilterField { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_candidates_multiplier")]
        public int? NumCandidatesMultiplier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_fields")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? ResultFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRetrievalConfig" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="collectionName"></param>
        /// <param name="dbName">
        /// Default Value: eleven_customer_support
        /// </param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
        /// <param name="kDense">
        /// Default Value: 5
        /// </param>
        /// <param name="kKeyword">
        /// Default Value: 5
        /// </param>
        /// <param name="denseWeight">
        /// Default Value: 1F
        /// </param>
        /// <param name="keywordWeight">
        /// Default Value: 1F
        /// </param>
        /// <param name="sourceWeight">
        /// Default Value: 1F
        /// </param>
        /// <param name="vectorIndexName">
        /// Default Value: default
        /// </param>
        /// <param name="embeddingField">
        /// Default Value: embedding
        /// </param>
        /// <param name="contentField">
        /// Default Value: content
        /// </param>
        /// <param name="filterField"></param>
        /// <param name="numCandidatesMultiplier">
        /// Default Value: 10
        /// </param>
        /// <param name="resultFields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SourceRetrievalConfig(
            string name,
            string collectionName,
            string? dbName,
            bool? enabled,
            int? kDense,
            int? kKeyword,
            double? denseWeight,
            double? keywordWeight,
            double? sourceWeight,
            string? vectorIndexName,
            string? embeddingField,
            string? contentField,
            string? filterField,
            int? numCandidatesMultiplier,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? resultFields)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.DbName = dbName;
            this.Enabled = enabled;
            this.KDense = kDense;
            this.KKeyword = kKeyword;
            this.DenseWeight = denseWeight;
            this.KeywordWeight = keywordWeight;
            this.SourceWeight = sourceWeight;
            this.VectorIndexName = vectorIndexName;
            this.EmbeddingField = embeddingField;
            this.ContentField = contentField;
            this.FilterField = filterField;
            this.NumCandidatesMultiplier = numCandidatesMultiplier;
            this.ResultFields = resultFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceRetrievalConfig" /> class.
        /// </summary>
        public SourceRetrievalConfig()
        {
        }
    }
}