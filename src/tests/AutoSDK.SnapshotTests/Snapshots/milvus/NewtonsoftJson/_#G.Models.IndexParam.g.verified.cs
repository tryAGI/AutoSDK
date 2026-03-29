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
        [global::Newtonsoft.Json.JsonProperty("metricType", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetricType { get; set; } = default!;

        /// <summary>
        /// The name of the target field on which an index is to be created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldName", Required = global::Newtonsoft.Json.Required.Always)]
        public string FieldName { get; set; } = default!;

        /// <summary>
        /// The name of the index to create, the value defaults to the target field name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexName", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexConfig")]
        public global::G.IndexConfig? IndexConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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