//HintName: G.Models.OperationDurationStatistics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OperationDurationStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_count")]
        public int? FailCount { get; set; }

        /// <summary>
        /// The average time taken by 128 latest operations, calculated as a weighted mean.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_duration_micros")]
        public float? AvgDurationMicros { get; set; }

        /// <summary>
        /// The minimum duration of the operations across all the measurements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_duration_micros")]
        public float? MinDurationMicros { get; set; }

        /// <summary>
        /// The maximum duration of the operations across all the measurements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_micros")]
        public float? MaxDurationMicros { get; set; }

        /// <summary>
        /// The total duration of all operations in microseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_micros")]
        public int? TotalDurationMicros { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_responded")]
        public global::System.DateTime? LastResponded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationDurationStatistics" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="failCount"></param>
        /// <param name="avgDurationMicros">
        /// The average time taken by 128 latest operations, calculated as a weighted mean.
        /// </param>
        /// <param name="minDurationMicros">
        /// The minimum duration of the operations across all the measurements.
        /// </param>
        /// <param name="maxDurationMicros">
        /// The maximum duration of the operations across all the measurements.
        /// </param>
        /// <param name="totalDurationMicros">
        /// The total duration of all operations in microseconds.
        /// </param>
        /// <param name="lastResponded"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OperationDurationStatistics(
            int count,
            int? failCount,
            float? avgDurationMicros,
            float? minDurationMicros,
            float? maxDurationMicros,
            int? totalDurationMicros,
            global::System.DateTime? lastResponded)
        {
            this.Count = count;
            this.FailCount = failCount;
            this.AvgDurationMicros = avgDurationMicros;
            this.MinDurationMicros = minDurationMicros;
            this.MaxDurationMicros = maxDurationMicros;
            this.TotalDurationMicros = totalDurationMicros;
            this.LastResponded = lastResponded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationDurationStatistics" /> class.
        /// </summary>
        public OperationDurationStatistics()
        {
        }
    }
}