//HintName: G.Models.KPITimeSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for time-segmented KPI data (compact format).<br/>
    /// Returns parallel arrays: interval_start and values.
    /// </summary>
    public sealed partial class KPITimeSegment
    {
        /// <summary>
        /// Array of time period start timestamps
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval_start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.DateTime> IntervalStart { get; set; } = default!;

        /// <summary>
        /// Array of KPI values, one per time period (parallel to interval_start)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPITimeSegment" /> class.
        /// </summary>
        /// <param name="intervalStart">
        /// Array of time period start timestamps
        /// </param>
        /// <param name="values">
        /// Array of KPI values, one per time period (parallel to interval_start)
        /// </param>
        public KPITimeSegment(
            global::System.Collections.Generic.IList<global::System.DateTime> intervalStart,
            global::System.Collections.Generic.IList<double> values)
        {
            this.IntervalStart = intervalStart ?? throw new global::System.ArgumentNullException(nameof(intervalStart));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPITimeSegment" /> class.
        /// </summary>
        public KPITimeSegment()
        {
        }
    }
}