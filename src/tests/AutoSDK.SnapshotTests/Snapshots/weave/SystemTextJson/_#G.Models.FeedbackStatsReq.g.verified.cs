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
        /// Filter by feedback_type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_type")]
        public string? FeedbackType { get; set; }

        /// <summary>
        /// Filter by trigger_ref (exact or prefix match for all-versions).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_ref")]
        public string? TriggerRef { get; set; }

        /// <summary>
        /// Bucket size in seconds. If omitted, auto-selected based on time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        public int? Granularity { get; set; }

        /// <summary>
        /// IANA timezone for bucket alignment.<br/>
        /// Default Value: UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Metrics to aggregate from payload_dump.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<global::G.FeedbackMetricSpec>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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