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
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Start { get; set; } = default!;

        /// <summary>
        /// Resolved end time (always UTC, regardless of the requested timezone).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime End { get; set; } = default!;

        /// <summary>
        /// Bucket size used (in seconds)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("granularity", Required = global::Newtonsoft.Json.Required.Always)]
        public int Granularity { get; set; } = default!;

        /// <summary>
        /// Timezone used for bucket alignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timezone { get; set; } = default!;

        /// <summary>
        /// Time-bucketed aggregations. Each dict has 'timestamp' (ISO string), 'count' (int), and '{agg}_{slug}' keys for each requested metric+aggregation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buckets")]
        public global::System.Collections.Generic.IList<object>? Buckets { get; set; }

        /// <summary>
        /// Aggregations over the full query window, keyed by metric slug (e.g. 'output_score'). Each value maps agg name to result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("window_stats")]
        public global::System.Collections.Generic.Dictionary<string, object>? WindowStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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