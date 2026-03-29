//HintName: G.Models.InsightRunDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsightRunDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("formatPlan")]
        public global::G.InsightRunFormatPlan? FormatPlan { get; set; }

        /// <summary>
        /// This is the optional time range override for the insight.<br/>
        /// If provided, overrides every field in the insight's timeRange.<br/>
        /// If this is provided with missing fields, defaults will be used, not the insight's timeRange.<br/>
        /// start default - "-7d"<br/>
        /// end default - "now"<br/>
        /// step default - "day"<br/>
        /// For Pie and Text Insights, step will be ignored even if provided.<br/>
        /// Example: { start: "2025-01-01", end: "2025-01-07", step: "day" }
        /// </summary>
        /// <example>{ start: "2025-01-01", end: "2025-01-07", step: "day" }</example>
        [global::Newtonsoft.Json.JsonProperty("timeRangeOverride")]
        public global::G.InsightTimeRangeWithStep? TimeRangeOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightRunDTO" /> class.
        /// </summary>
        /// <param name="formatPlan"></param>
        /// <param name="timeRangeOverride">
        /// This is the optional time range override for the insight.<br/>
        /// If provided, overrides every field in the insight's timeRange.<br/>
        /// If this is provided with missing fields, defaults will be used, not the insight's timeRange.<br/>
        /// start default - "-7d"<br/>
        /// end default - "now"<br/>
        /// step default - "day"<br/>
        /// For Pie and Text Insights, step will be ignored even if provided.<br/>
        /// Example: { start: "2025-01-01", end: "2025-01-07", step: "day" }
        /// </param>
        public InsightRunDTO(
            global::G.InsightRunFormatPlan? formatPlan,
            global::G.InsightTimeRangeWithStep? timeRangeOverride)
        {
            this.FormatPlan = formatPlan;
            this.TimeRangeOverride = timeRangeOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightRunDTO" /> class.
        /// </summary>
        public InsightRunDTO()
        {
        }
    }
}