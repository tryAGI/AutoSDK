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
        [global::Newtonsoft.Json.JsonProperty("fieldName", Required = global::Newtonsoft.Json.Required.Always)]
        public string FieldName { get; set; } = default!;

        /// <summary>
        /// The name of this index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexName", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexName { get; set; } = default!;

        /// <summary>
        /// The metric type of this index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metricType", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetricType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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