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
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TimeRangeStepJsonConverter))]
        public global::G.TimeRangeStep? Step { get; set; }

        /// <summary>
        /// This is the start date for the time range.<br/>
        /// If not provided, defaults to the 7 days ago.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        /// This is the end date for the time range.<br/>
        /// If not provided, defaults to now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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