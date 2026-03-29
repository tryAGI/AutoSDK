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
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldName { get; set; }

        /// <summary>
        /// The name of the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexState")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexState { get; set; }

        /// <summary>
        /// The type of this index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexType { get; set; }

        /// <summary>
        /// The total number o rows that have been indexed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexedRows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IndexedRows { get; set; }

        /// <summary>
        /// The type of the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetricType { get; set; }

        /// <summary>
        /// The number of rows that are waiting to be indexed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingRows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingRows { get; set; }

        /// <summary>
        /// The total number of entities/rows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRows { get; set; }

        /// <summary>
        /// The reason for the failure to build indexes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failReason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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