//HintName: G.Models.QaViewFilter.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Filter criteria for QA views.
    /// </summary>
    public sealed partial class QaViewFilter
    {
        /// <summary>
        /// Filter by agent(s).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent")]
        public global::System.Collections.Generic.IList<global::G.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// Start timestamp filter (epoch ms).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_timestamp")]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public global::G.NumberFilter? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disconnection_reason")]
        public global::G.AllOf<global::G.EnumFilter, global::G.QaViewFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed")]
        public global::G.OneOf<bool?, global::G.BooleanFilter>? Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("calibrated")]
        public global::G.OneOf<bool?, global::G.BooleanFilter>? Calibrated { get; set; }

        /// <summary>
        /// Deprecated: use 'agent' instead.
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
        /// Deprecated: use 'score' instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_range")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.QaViewFilterScoreRange? ScoreRange { get; set; }

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
        /// Initializes a new instance of the <see cref="QaViewFilter" /> class.
        /// </summary>
        /// <param name="agent">
        /// Filter by agent(s).
        /// </param>
        /// <param name="startTimestamp">
        /// Start timestamp filter (epoch ms).
        /// </param>
        /// <param name="score"></param>
        /// <param name="disconnectionReason"></param>
        /// <param name="passed"></param>
        /// <param name="calibrated"></param>
        /// <param name="dateRange"></param>
        public QaViewFilter(
            global::System.Collections.Generic.IList<global::G.AgentFilter>? agent,
            global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? startTimestamp,
            global::G.NumberFilter? score,
            global::G.AllOf<global::G.EnumFilter, global::G.QaViewFilterDisconnectionReason>? disconnectionReason,
            global::G.OneOf<bool?, global::G.BooleanFilter>? passed,
            global::G.OneOf<bool?, global::G.BooleanFilter>? calibrated,
            global::G.DateRange? dateRange)
        {
            this.Agent = agent;
            this.StartTimestamp = startTimestamp;
            this.Score = score;
            this.DisconnectionReason = disconnectionReason;
            this.Passed = passed;
            this.Calibrated = calibrated;
            this.DateRange = dateRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QaViewFilter" /> class.
        /// </summary>
        public QaViewFilter()
        {
        }
    }
}