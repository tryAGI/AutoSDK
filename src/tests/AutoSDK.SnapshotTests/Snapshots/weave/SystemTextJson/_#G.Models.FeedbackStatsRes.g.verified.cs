//HintName: G.Models.FeedbackStatsRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response with time-series feedback statistics.
    /// </summary>
    public sealed partial class FeedbackStatsRes
    {
        /// <summary>
        /// Resolved start time (always UTC, regardless of the requested timezone).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// Resolved end time (always UTC, regardless of the requested timezone).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// Bucket size used (in seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Granularity { get; set; }

        /// <summary>
        /// Timezone used for bucket alignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// Time-bucketed aggregations. Each dict has 'timestamp' (ISO string), 'count' (int), and '{agg}_{slug}' keys for each requested metric+aggregation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        public global::System.Collections.Generic.IList<object>? Buckets { get; set; }

        /// <summary>
        /// Aggregations over the full query window, keyed by metric slug (e.g. 'output_score'). Each value maps agg name to result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_stats")]
        public global::System.Collections.Generic.Dictionary<string, object>? WindowStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackStatsRes" /> class.
        /// </summary>
        /// <param name="start">
        /// Resolved start time (always UTC, regardless of the requested timezone).
        /// </param>
        /// <param name="end">
        /// Resolved end time (always UTC, regardless of the requested timezone).
        /// </param>
        /// <param name="granularity">
        /// Bucket size used (in seconds)
        /// </param>
        /// <param name="timezone">
        /// Timezone used for bucket alignment
        /// </param>
        /// <param name="buckets">
        /// Time-bucketed aggregations. Each dict has 'timestamp' (ISO string), 'count' (int), and '{agg}_{slug}' keys for each requested metric+aggregation.
        /// </param>
        /// <param name="windowStats">
        /// Aggregations over the full query window, keyed by metric slug (e.g. 'output_score'). Each value maps agg name to result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackStatsRes(
            global::System.DateTime start,
            global::System.DateTime end,
            int granularity,
            string timezone,
            global::System.Collections.Generic.IList<object>? buckets,
            global::System.Collections.Generic.Dictionary<string, object>? windowStats)
        {
            this.Start = start;
            this.End = end;
            this.Granularity = granularity;
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.Buckets = buckets;
            this.WindowStats = windowStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackStatsRes" /> class.
        /// </summary>
        public FeedbackStatsRes()
        {
        }
    }
}