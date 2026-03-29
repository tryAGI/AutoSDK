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
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeriesData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TimeSeriesDataPoint> TimeSeriesData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderMetricsMetrics" /> class.
        /// </summary>
        /// <param name="timeSeriesData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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