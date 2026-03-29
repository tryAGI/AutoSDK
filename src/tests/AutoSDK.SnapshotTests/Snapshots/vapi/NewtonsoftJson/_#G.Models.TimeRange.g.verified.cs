//HintName: G.Models.TimeRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeRange
    {
        /// <summary>
        /// This is the time step for aggregations.<br/>
        /// If not provided, defaults to returning for the entire time range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step")]
        public global::G.TimeRangeStep? Step { get; set; }

        /// <summary>
        /// This is the start date for the time range.<br/>
        /// If not provided, defaults to the 7 days ago.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        /// This is the end date for the time range.<br/>
        /// If not provided, defaults to now.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public global::System.DateTime? End { get; set; }

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
        /// Initializes a new instance of the <see cref="TimeRange" /> class.
        /// </summary>
        /// <param name="step">
        /// This is the time step for aggregations.<br/>
        /// If not provided, defaults to returning for the entire time range.
        /// </param>
        /// <param name="start">
        /// This is the start date for the time range.<br/>
        /// If not provided, defaults to the 7 days ago.
        /// </param>
        /// <param name="end">
        /// This is the end date for the time range.<br/>
        /// If not provided, defaults to now.
        /// </param>
        /// <param name="timezone">
        /// This is the timezone you want to set for the query.<br/>
        /// If not provided, defaults to UTC.
        /// </param>
        public TimeRange(
            global::G.TimeRangeStep? step,
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? timezone)
        {
            this.Step = step;
            this.Start = start;
            this.End = end;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRange" /> class.
        /// </summary>
        public TimeRange()
        {
        }
    }
}