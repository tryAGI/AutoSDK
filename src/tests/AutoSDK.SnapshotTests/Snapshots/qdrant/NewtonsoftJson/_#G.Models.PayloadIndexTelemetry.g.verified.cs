//HintName: G.Models.PayloadIndexTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayloadIndexTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field_name")]
        public string? FieldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexType { get; set; } = default!;

        /// <summary>
        /// The amount of values indexed for all points.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points_values_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PointsValuesCount { get; set; } = default!;

        /// <summary>
        /// The amount of points that have at least one value indexed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("points_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int PointsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("histogram_bucket_size")]
        public int? HistogramBucketSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadIndexTelemetry" /> class.
        /// </summary>
        /// <param name="indexType"></param>
        /// <param name="pointsValuesCount">
        /// The amount of values indexed for all points.
        /// </param>
        /// <param name="pointsCount">
        /// The amount of points that have at least one value indexed.
        /// </param>
        /// <param name="fieldName"></param>
        /// <param name="histogramBucketSize"></param>
        public PayloadIndexTelemetry(
            string indexType,
            int pointsValuesCount,
            int pointsCount,
            string? fieldName,
            int? histogramBucketSize)
        {
            this.FieldName = fieldName;
            this.IndexType = indexType ?? throw new global::System.ArgumentNullException(nameof(indexType));
            this.PointsValuesCount = pointsValuesCount;
            this.PointsCount = pointsCount;
            this.HistogramBucketSize = histogramBucketSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadIndexTelemetry" /> class.
        /// </summary>
        public PayloadIndexTelemetry()
        {
        }
    }
}