//HintName: G.Models.KpiMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KpiMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.KpiMetricType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_value")]
        public double? CurrentValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_value")]
        public double? PreviousValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KpiMetric" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="currentValue"></param>
        /// <param name="previousValue"></param>
        public KpiMetric(
            global::G.KpiMetricType? type,
            double? currentValue,
            double? previousValue)
        {
            this.Type = type;
            this.CurrentValue = currentValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KpiMetric" /> class.
        /// </summary>
        public KpiMetric()
        {
        }
    }
}