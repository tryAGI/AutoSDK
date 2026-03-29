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
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Breakdown> OverallBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.Breakdown>> TimeBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownMetric" /> class.
        /// </summary>
        /// <param name="overallBreakdown"></param>
        /// <param name="timeBreakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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