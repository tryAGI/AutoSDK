//HintName: G.Models.FeedbackStatsReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for aggregated feedback statistics over time buckets.
    /// </summary>
    public sealed partial class FeedbackStatsReq
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
        /// Filter by feedback_type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_type")]
        public string? FeedbackType { get; set; }

        /// <summary>
        /// Filter by trigger_ref (exact or prefix match for all-versions).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_ref")]
        public string? TriggerRef { get; set; }

        /// <summary>
        /// Bucket size in seconds. If omitted, auto-selected based on time range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("granularity")]
        public int? Granularity { get; set; }

        /// <summary>
        /// IANA timezone for bucket alignment.<br/>
        /// Default Value: UTC
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Metrics to aggregate from payload_dump.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics")]
        public global::System.Collections.Generic.IList<global::G.FeedbackMetricSpec>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackStatsReq" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="start">
        /// Inclusive start time (UTC, ISO 8601).
        /// </param>
        /// <param name="end">
        /// Exclusive end time (UTC, ISO 8601). Defaults to now if omitted.
        /// </param>
        /// <param name="feedbackType">
        /// Filter by feedback_type.
        /// </param>
        /// <param name="triggerRef">
        /// Filter by trigger_ref (exact or prefix match for all-versions).
        /// </param>
        /// <param name="granularity">
        /// Bucket size in seconds. If omitted, auto-selected based on time range.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone for bucket alignment.<br/>
        /// Default Value: UTC
        /// </param>
        /// <param name="metrics">
        /// Metrics to aggregate from payload_dump.
        /// </param>
        public FeedbackStatsReq(
            string projectId,
            global::System.DateTime start,
            global::System.DateTime? end,
            string? feedbackType,
            string? triggerRef,
            int? granularity,
            string? timezone,
            global::System.Collections.Generic.IList<global::G.FeedbackMetricSpec>? metrics)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Start = start;
            this.End = end;
            this.FeedbackType = feedbackType;
            this.TriggerRef = triggerRef;
            this.Granularity = granularity;
            this.Timezone = timezone;
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackStatsReq" /> class.
        /// </summary>
        public FeedbackStatsReq()
        {
        }
    }
}