//HintName: G.Models.Breakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Breakdown
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetricName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_value", Required = global::Newtonsoft.Json.Required.Always)]
        public double MetricValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Breakdown" /> class.
        /// </summary>
        /// <param name="metricName"></param>
        /// <param name="metricValue"></param>
        public Breakdown(
            string metricName,
            double metricValue)
        {
            this.MetricName = metricName ?? throw new global::System.ArgumentNullException(nameof(metricName));
            this.MetricValue = metricValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Breakdown" /> class.
        /// </summary>
        public Breakdown()
        {
        }
    }
}