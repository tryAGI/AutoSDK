//HintName: G.Models.CallStatsReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for aggregated call statistics over a time range.
    /// </summary>
    public sealed partial class CallStatsReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Inclusive start time (UTC, ISO 8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// Exclusive end time (UTC, ISO 8601). Defaults to now if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// Bucket size in seconds (e.g., 3600 for 1 hour). If omitted, auto-selected based on time range. Will be adjusted if it would produce more than 10,000 buckets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        public int? Granularity { get; set; }

        /// <summary>
        /// Usage metrics (tokens, cost) to compute. Grouped by timestamp and model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_metrics")]
        public global::System.Collections.Generic.IList<global::G.UsageMetricSpec>? UsageMetrics { get; set; }

        /// <summary>
        /// Call-level metrics (latency, counts) to compute. Grouped by timestamp only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_metrics")]
        public global::System.Collections.Generic.IList<global::G.CallMetricSpec>? CallMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.CallsFilter? Filter { get; set; }

        /// <summary>
        /// IANA timezone for bucket alignment (e.g., 'America/New_York')<br/>
        /// Default Value: UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStatsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start">
        /// Inclusive start time (UTC, ISO 8601).
        /// </param>
        /// <param name="end">
        /// Exclusive end time (UTC, ISO 8601). Defaults to now if omitted.
        /// </param>
        /// <param name="granularity">
        /// Bucket size in seconds (e.g., 3600 for 1 hour). If omitted, auto-selected based on time range. Will be adjusted if it would produce more than 10,000 buckets.
        /// </param>
        /// <param name="usageMetrics">
        /// Usage metrics (tokens, cost) to compute. Grouped by timestamp and model.
        /// </param>
        /// <param name="callMetrics">
        /// Call-level metrics (latency, counts) to compute. Grouped by timestamp only.
        /// </param>
        /// <param name="filter"></param>
        /// <param name="timezone">
        /// IANA timezone for bucket alignment (e.g., 'America/New_York')<br/>
        /// Default Value: UTC
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallStatsReq(
            string projectId,
            global::System.DateTime start,
            global::System.DateTime? end,
            int? granularity,
            global::System.Collections.Generic.IList<global::G.UsageMetricSpec>? usageMetrics,
            global::System.Collections.Generic.IList<global::G.CallMetricSpec>? callMetrics,
            global::G.CallsFilter? filter,
            string? timezone)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Start = start;
            this.End = end;
            this.Granularity = granularity;
            this.UsageMetrics = usageMetrics;
            this.CallMetrics = callMetrics;
            this.Filter = filter;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStatsReq" /> class.
        /// </summary>
        public CallStatsReq()
        {
        }
    }
}