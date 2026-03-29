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
        [global::System.Text.Json.Serialization.JsonPropertyName("field_name")]
        public string? FieldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexType { get; set; }

        /// <summary>
        /// The amount of values indexed for all points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points_values_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PointsValuesCount { get; set; }

        /// <summary>
        /// The amount of points that have at least one value indexed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PointsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("histogram_bucket_size")]
        public int? HistogramBucketSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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