//HintName: G.Models.BreakdownMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BreakdownMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall_breakdown", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Breakdown> OverallBreakdown { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time_breakdown", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.Breakdown>> TimeBreakdown { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownMetric" /> class.
        /// </summary>
        /// <param name="overallBreakdown"></param>
        /// <param name="timeBreakdown"></param>
        public BreakdownMetric(
            global::System.Collections.Generic.IList<global::G.Breakdown> overallBreakdown,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.Breakdown>> timeBreakdown)
        {
            this.OverallBreakdown = overallBreakdown ?? throw new global::System.ArgumentNullException(nameof(overallBreakdown));
            this.TimeBreakdown = timeBreakdown ?? throw new global::System.ArgumentNullException(nameof(timeBreakdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownMetric" /> class.
        /// </summary>
        public BreakdownMetric()
        {
        }
    }
}