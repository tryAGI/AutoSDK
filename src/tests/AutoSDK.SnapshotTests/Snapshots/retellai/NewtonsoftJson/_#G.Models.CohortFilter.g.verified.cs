//HintName: G.Models.CohortFilter.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Call filter criteria to create QA.
    /// </summary>
    public sealed partial class CohortFilter
    {
        /// <summary>
        /// Filter by agent(s), which are connected by "OR".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::System.Collections.Generic.IList<global::G.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// Start timestamp filter (epoch ms). Required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_timestamp")]
        public global::G.OneOf<global::G.AllOf<global::G.NumberFilter, global::G.CohortFilterStartTimestampVariant1>?, global::G.RangeFilter>? StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disconnection_reason")]
        public global::G.AllOf<global::G.EnumFilter, global::G.CohortFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        /// Filter calls by duration in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms")]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? DurationMs { get; set; }

        /// <summary>
        /// Filter calls by custom analysis data fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_analysis_data")]
        public global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? CustomAnalysisData { get; set; }

        /// <summary>
        /// Deprecated: use 'agent' instead. Either 'agent' or 'agents' must be provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.AgentFilter>? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_range")]
        public global::G.DateRange? DateRange { get; set; }

        /// <summary>
        /// Deprecated: use 'duration_ms' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_duration_filter")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.CohortFilterCallDurationFilter? CallDurationFilter { get; set; }

        /// <summary>
        /// Deprecated: use 'custom_analysis_data' instead. Custom analysis data filter criteria for filtering calls based on custom analysis data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_call_analysis")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? PostCallAnalysis { get; set; }

        /// <summary>
        /// Deprecated: use 'disconnection_reason' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disconnection_reasons")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? DisconnectionReasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilter" /> class.
        /// </summary>
        /// <param name="agent">
        /// Filter by agent(s), which are connected by "OR".
        /// </param>
        /// <param name="startTimestamp">
        /// Start timestamp filter (epoch ms). Required.
        /// </param>
        /// <param name="disconnectionReason"></param>
        /// <param name="durationMs">
        /// Filter calls by duration in milliseconds.
        /// </param>
        /// <param name="customAnalysisData">
        /// Filter calls by custom analysis data fields.
        /// </param>
        /// <param name="dateRange"></param>
        public CohortFilter(
            global::System.Collections.Generic.IList<global::G.AgentFilter>? agent,
            global::G.OneOf<global::G.AllOf<global::G.NumberFilter, global::G.CohortFilterStartTimestampVariant1>?, global::G.RangeFilter>? startTimestamp,
            global::G.AllOf<global::G.EnumFilter, global::G.CohortFilterDisconnectionReason>? disconnectionReason,
            global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? durationMs,
            global::System.Collections.Generic.IList<global::G.CustomFieldFilter>? customAnalysisData,
            global::G.DateRange? dateRange)
        {
            this.Agent = agent;
            this.StartTimestamp = startTimestamp;
            this.DisconnectionReason = disconnectionReason;
            this.DurationMs = durationMs;
            this.CustomAnalysisData = customAnalysisData;
            this.DateRange = dateRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortFilter" /> class.
        /// </summary>
        public CohortFilter()
        {
        }
    }
}