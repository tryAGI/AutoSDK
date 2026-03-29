//HintName: G.Models.Interval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time). When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public sealed partial class Interval
    {
        /// <summary>
        /// Optional. Inclusive start of the interval. If specified, a Timestamp matching this interval will have to be the same or after the start.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startTime")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Optional. Exclusive end of the interval. If specified, a Timestamp matching this interval will have to be before the end.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endTime")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Interval" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Optional. Inclusive start of the interval. If specified, a Timestamp matching this interval will have to be the same or after the start.
        /// </param>
        /// <param name="endTime">
        /// Optional. Exclusive end of the interval. If specified, a Timestamp matching this interval will have to be before the end.
        /// </param>
        public Interval(
            string? startTime,
            string? endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interval" /> class.
        /// </summary>
        public Interval()
        {
        }
    }
}