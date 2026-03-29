//HintName: G.Models.ProjectMetricRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectMetricRequestPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_type")]
        public global::G.ProjectMetricRequestPublicMetricType? MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval")]
        public global::G.ProjectMetricRequestPublicInterval? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_start")]
        public global::System.DateTime? IntervalStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_end")]
        public global::System.DateTime? IntervalEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("span_filters")]
        public global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? SpanFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_filters")]
        public global::System.Collections.Generic.IList<global::G.TraceFilterPublic>? TraceFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_filters")]
        public global::System.Collections.Generic.IList<global::G.TraceThreadFilterPublic>? ThreadFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breakdown")]
        public global::G.BreakdownConfigPublic? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetricRequestPublic" /> class.
        /// </summary>
        /// <param name="metricType"></param>
        /// <param name="interval"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="spanFilters"></param>
        /// <param name="traceFilters"></param>
        /// <param name="threadFilters"></param>
        /// <param name="breakdown"></param>
        public ProjectMetricRequestPublic(
            global::G.ProjectMetricRequestPublicMetricType? metricType,
            global::G.ProjectMetricRequestPublicInterval? interval,
            global::System.DateTime? intervalStart,
            global::System.DateTime? intervalEnd,
            global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? spanFilters,
            global::System.Collections.Generic.IList<global::G.TraceFilterPublic>? traceFilters,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilterPublic>? threadFilters,
            global::G.BreakdownConfigPublic? breakdown)
        {
            this.MetricType = metricType;
            this.Interval = interval;
            this.IntervalStart = intervalStart;
            this.IntervalEnd = intervalEnd;
            this.SpanFilters = spanFilters;
            this.TraceFilters = traceFilters;
            this.ThreadFilters = threadFilters;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetricRequestPublic" /> class.
        /// </summary>
        public ProjectMetricRequestPublic()
        {
        }
    }
}