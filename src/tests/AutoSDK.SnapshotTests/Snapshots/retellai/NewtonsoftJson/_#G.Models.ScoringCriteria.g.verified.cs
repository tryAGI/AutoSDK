//HintName: G.Models.ScoringCriteria.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoringCriteria
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_conditions")]
        public global::System.Collections.Generic.IList<global::G.ScoringCriteriaCustomCondition>? CustomConditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performance_metrics")]
        public global::System.Collections.Generic.IList<global::G.PerformanceMetricCriteria>? PerformanceMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoringCriteria" /> class.
        /// </summary>
        /// <param name="customConditions"></param>
        /// <param name="performanceMetrics"></param>
        public ScoringCriteria(
            global::System.Collections.Generic.IList<global::G.ScoringCriteriaCustomCondition>? customConditions,
            global::System.Collections.Generic.IList<global::G.PerformanceMetricCriteria>? performanceMetrics)
        {
            this.CustomConditions = customConditions;
            this.PerformanceMetrics = performanceMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoringCriteria" /> class.
        /// </summary>
        public ScoringCriteria()
        {
        }
    }
}