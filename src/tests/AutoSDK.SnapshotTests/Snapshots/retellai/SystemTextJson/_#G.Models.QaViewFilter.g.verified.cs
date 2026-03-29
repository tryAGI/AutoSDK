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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::System.Collections.Generic.IList<global::G.AgentFilter>? Agent { get; set; }

        /// <summary>
        /// Start timestamp filter (epoch ms).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.NumberFilter, global::G.RangeFilter>))]
        public global::G.OneOf<global::G.NumberFilter, global::G.RangeFilter>? StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public global::G.NumberFilter? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.EnumFilter, global::G.QaViewFilterDisconnectionReason>))]
        public global::G.AllOf<global::G.EnumFilter, global::G.QaViewFilterDisconnectionReason>? DisconnectionReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<bool?, global::G.BooleanFilter>))]
        public global::G.OneOf<bool?, global::G.BooleanFilter>? Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibrated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<bool?, global::G.BooleanFilter>))]
        public global::G.OneOf<bool?, global::G.BooleanFilter>? Calibrated { get; set; }

        /// <summary>
        /// Deprecated: use 'agent' instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.AgentFilter>? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_range")]
        public global::G.DateRange? DateRange { get; set; }

        /// <summary>
        /// Deprecated: use 'score' instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_range")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.QaViewFilterScoreRange? ScoreRange { get; set; }

        /// <summary>
        /// Deprecated: use 'disconnection_reason' instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disconnection_reasons")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.DisconnectionReason4>? DisconnectionReasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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