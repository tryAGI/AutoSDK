//HintName: G.Models.DateRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DateRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartTimeMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time_ms")]
        public double? EndTimeMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DateRange" /> class.
        /// </summary>
        /// <param name="startTimeMs"></param>
        /// <param name="endTimeMs"></param>
        public DateRange(
            double startTimeMs,
            double? endTimeMs)
        {
            this.StartTimeMs = startTimeMs;
            this.EndTimeMs = endTimeMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateRange" /> class.
        /// </summary>
        public DateRange()
        {
        }
    }
}