//HintName: G.Models.IndexDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexDetail
    {
        /// <summary>
        /// The name of the target field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fieldName", Required = global::Newtonsoft.Json.Required.Always)]
        public string FieldName { get; set; } = default!;

        /// <summary>
        /// The name of the index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexName", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexState", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexState { get; set; } = default!;

        /// <summary>
        /// The type of this index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexType", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexType { get; set; } = default!;

        /// <summary>
        /// The total number o rows that have been indexed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexedRows", Required = global::Newtonsoft.Json.Required.Always)]
        public int IndexedRows { get; set; } = default!;

        /// <summary>
        /// The type of the metric.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metricType", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetricType { get; set; } = default!;

        /// <summary>
        /// The number of rows that are waiting to be indexed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pendingRows", Required = global::Newtonsoft.Json.Required.Always)]
        public int PendingRows { get; set; } = default!;

        /// <summary>
        /// The total number of entities/rows
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalRows", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalRows { get; set; } = default!;

        /// <summary>
        /// The reason for the failure to build indexes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failReason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexDetail" /> class.
        /// </summary>
        /// <param name="fieldName">
        /// The name of the target field.
        /// </param>
        /// <param name="indexName">
        /// The name of the index.
        /// </param>
        /// <param name="indexState"></param>
        /// <param name="indexType">
        /// The type of this index.
        /// </param>
        /// <param name="indexedRows">
        /// The total number o rows that have been indexed.
        /// </param>
        /// <param name="metricType">
        /// The type of the metric.
        /// </param>
        /// <param name="pendingRows">
        /// The number of rows that are waiting to be indexed.
        /// </param>
        /// <param name="totalRows">
        /// The total number of entities/rows
        /// </param>
        /// <param name="failReason">
        /// The reason for the failure to build indexes.
        /// </param>
        public IndexDetail(
            string fieldName,
            string indexName,
            string indexState,
            string indexType,
            int indexedRows,
            string metricType,
            int pendingRows,
            int totalRows,
            string? failReason)
        {
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.IndexState = indexState ?? throw new global::System.ArgumentNullException(nameof(indexState));
            this.IndexType = indexType ?? throw new global::System.ArgumentNullException(nameof(indexType));
            this.IndexedRows = indexedRows;
            this.MetricType = metricType ?? throw new global::System.ArgumentNullException(nameof(metricType));
            this.PendingRows = pendingRows;
            this.TotalRows = totalRows;
            this.FailReason = failReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexDetail" /> class.
        /// </summary>
        public IndexDetail()
        {
        }
    }
}