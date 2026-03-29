//HintName: G.Models.InsightTimeRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsightTimeRange
    {
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
        [global::Newtonsoft.Json.JsonProperty("start")]
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
        [global::Newtonsoft.Json.JsonProperty("end")]
        public object? End { get; set; }

        /// <summary>
        /// This is the timezone you want to set for the query.<br/>
        /// If not provided, defaults to UTC.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightTimeRange" /> class.
        /// </summary>
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
        public InsightTimeRange(
            object? start,
            object? end,
            string? timezone)
        {
            this.Start = start;
            this.End = end;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightTimeRange" /> class.
        /// </summary>
        public InsightTimeRange()
        {
        }
    }
}