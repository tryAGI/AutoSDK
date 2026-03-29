//HintName: G.Models.IndexParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexParam
    {
        /// <summary>
        /// The similarity metric type used to build the index.<br/>
        /// Possible values for float vector embeddings.<br/>
        /// - For an Milvus instance, possible values are **L2**, **IP**, and **COSINE**, and those for binary vector embeddings are **Jaccard** and **Hamming**.  For details, refer to [Similarity Metrics](https://milvus.io/docs/metric.md).<br/>
        /// - For a Zilliz Cloud cluster, possible values are **L2**, **IP**, and **COSINE**. Read [Similarity Metrics Explained](https://docs.zilliz.com/docs/search-metrics-explained) to get more.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetricType { get; set; }

        /// <summary>
        /// The name of the target field on which an index is to be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldName { get; set; }

        /// <summary>
        /// The name of the index to create, the value defaults to the target field name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexConfig")]
        public global::G.IndexConfig? IndexConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexParam" /> class.
        /// </summary>
        /// <param name="metricType">
        /// The similarity metric type used to build the index.<br/>
        /// Possible values for float vector embeddings.<br/>
        /// - For an Milvus instance, possible values are **L2**, **IP**, and **COSINE**, and those for binary vector embeddings are **Jaccard** and **Hamming**.  For details, refer to [Similarity Metrics](https://milvus.io/docs/metric.md).<br/>
        /// - For a Zilliz Cloud cluster, possible values are **L2**, **IP**, and **COSINE**. Read [Similarity Metrics Explained](https://docs.zilliz.com/docs/search-metrics-explained) to get more.
        /// </param>
        /// <param name="fieldName">
        /// The name of the target field on which an index is to be created.
        /// </param>
        /// <param name="indexName">
        /// The name of the index to create, the value defaults to the target field name.
        /// </param>
        /// <param name="indexConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexParam(
            string metricType,
            string fieldName,
            string indexName,
            global::G.IndexConfig? indexConfig)
        {
            this.MetricType = metricType ?? throw new global::System.ArgumentNullException(nameof(metricType));
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.IndexConfig = indexConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexParam" /> class.
        /// </summary>
        public IndexParam()
        {
        }
    }
}