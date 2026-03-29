//HintName: G.Models.ProviderMetricsMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderMetricsMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeSeriesData", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TimeSeriesDataPoint> TimeSeriesData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderMetricsMetrics" /> class.
        /// </summary>
        /// <param name="timeSeriesData"></param>
        public ProviderMetricsMetrics(
            global::System.Collections.Generic.IList<global::G.TimeSeriesDataPoint> timeSeriesData)
        {
            this.TimeSeriesData = timeSeriesData ?? throw new global::System.ArgumentNullException(nameof(timeSeriesData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderMetricsMetrics" /> class.
        /// </summary>
        public ProviderMetricsMetrics()
        {
        }
    }
}