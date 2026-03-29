//HintName: G.Models.CreateVectordbCollectionsDescribeResponseDataIndexe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectordbCollectionsDescribeResponseDataIndexe
    {
        /// <summary>
        /// The target field of this index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fieldName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldName { get; set; }

        /// <summary>
        /// The name of this index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// The metric type of this index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetricType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsDescribeResponseDataIndexe" /> class.
        /// </summary>
        /// <param name="fieldName">
        /// The target field of this index.
        /// </param>
        /// <param name="indexName">
        /// The name of this index.
        /// </param>
        /// <param name="metricType">
        /// The metric type of this index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectordbCollectionsDescribeResponseDataIndexe(
            string fieldName,
            string indexName,
            string metricType)
        {
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.MetricType = metricType ?? throw new global::System.ArgumentNullException(nameof(metricType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectordbCollectionsDescribeResponseDataIndexe" /> class.
        /// </summary>
        public CreateVectordbCollectionsDescribeResponseDataIndexe()
        {
        }
    }
}