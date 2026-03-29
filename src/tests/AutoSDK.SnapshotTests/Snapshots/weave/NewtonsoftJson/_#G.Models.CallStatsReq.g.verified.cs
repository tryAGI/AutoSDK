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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Inclusive start time (UTC, ISO 8601).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Start { get; set; } = default!;

        /// <summary>
        /// Exclusive end time (UTC, ISO 8601). Defaults to now if omitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// Bucket size in seconds (e.g., 3600 for 1 hour). If omitted, auto-selected based on time range. Will be adjusted if it would produce more than 10,000 buckets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("granularity")]
        public int? Granularity { get; set; }

        /// <summary>
        /// Usage metrics (tokens, cost) to compute. Grouped by timestamp and model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_metrics")]
        public global::System.Collections.Generic.IList<global::G.UsageMetricSpec>? UsageMetrics { get; set; }

        /// <summary>
        /// Call-level metrics (latency, counts) to compute. Grouped by timestamp only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_metrics")]
        public global::System.Collections.Generic.IList<global::G.CallMetricSpec>? CallMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.CallsFilter? Filter { get; set; }

        /// <summary>
        /// IANA timezone for bucket alignment (e.g., 'America/New_York')<br/>
        /// Default Value: UTC
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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