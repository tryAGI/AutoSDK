//HintName: G.Models.InsightTimeRangeWithStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsightTimeRangeWithStep
    {
        /// <summary>
        /// This is the group by step for aggregation.<br/>
        /// If not provided, defaults to group by day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InsightTimeRangeWithStepStepJsonConverter))]
        public global::G.InsightTimeRangeWithStepStep? Step { get; set; }

        /// <summary>
        /// This is the start date for the time range.<br/>
        /// Should be a valid ISO 8601 date-time string or relative time string.<br/>
        /// If not provided, defaults to the 7 days ago.<br/>
        /// Relative time strings of the format "-{number}{unit}" are allowed.<br/>
        /// Valid units are:<br/>
        /// - d: days<br/>
        /// - h: hours<br/>
        /// - w: weeks<br/>
        /// - m: months<br/>
        /// - y: years<br/>
        /// Example: "2025-01-01" or "-7d" or "now"
        /// </summary>
        /// <example>"2025-01-01" or "-7d" or "now"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public object? Start { get; set; }

        /// <summary>
        /// This is the end date for the time range.<br/>
        /// Should be a valid ISO 8601 date-time string or relative time string.<br/>
        /// If not provided, defaults to now.<br/>
        /// Relative time strings of the format "-{number}{unit}" are allowed.<br/>
        /// Valid units are:<br/>
        /// - d: days<br/>
        /// - h: hours<br/>
        /// - w: weeks<br/>
        /// - m: months<br/>
        /// - y: years<br/>
        /// Example: "2025-01-01" or "now"
        /// </summary>
        /// <example>"2025-01-01" or "now"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public object? End { get; set; }

        /// <summary>
        /// This is the timezone you want to set for the query.<br/>
        /// If not provided, defaults to UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightTimeRangeWithStep" /> class.
        /// </summary>
        /// <param name="step">
        /// This is the group by step for aggregation.<br/>
        /// If not provided, defaults to group by day.
        /// </param>
        /// <param name="start">
        /// This is the start date for the time range.<br/>
        /// Should be a valid ISO 8601 date-time string or relative time string.<br/>
        /// If not provided, defaults to the 7 days ago.<br/>
        /// Relative time strings of the format "-{number}{unit}" are allowed.<br/>
        /// Valid units are:<br/>
        /// - d: days<br/>
        /// - h: hours<br/>
        /// - w: weeks<br/>
        /// - m: months<br/>
        /// - y: years<br/>
        /// Example: "2025-01-01" or "-7d" or "now"
        /// </param>
        /// <param name="end">
        /// This is the end date for the time range.<br/>
        /// Should be a valid ISO 8601 date-time string or relative time string.<br/>
        /// If not provided, defaults to now.<br/>
        /// Relative time strings of the format "-{number}{unit}" are allowed.<br/>
        /// Valid units are:<br/>
        /// - d: days<br/>
        /// - h: hours<br/>
        /// - w: weeks<br/>
        /// - m: months<br/>
        /// - y: years<br/>
        /// Example: "2025-01-01" or "now"
        /// </param>
        /// <param name="timezone">
        /// This is the timezone you want to set for the query.<br/>
        /// If not provided, defaults to UTC.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsightTimeRangeWithStep(
            global::G.InsightTimeRangeWithStepStep? step,
            object? start,
            object? end,
            string? timezone)
        {
            this.Step = step;
            this.Start = start;
            this.End = end;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightTimeRangeWithStep" /> class.
        /// </summary>
        public InsightTimeRangeWithStep()
        {
        }
    }
}