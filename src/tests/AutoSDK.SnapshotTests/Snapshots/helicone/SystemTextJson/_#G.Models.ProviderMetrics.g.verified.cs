//HintName: G.Models.ProviderMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.MetricsData, global::G.ProviderMetricsMetrics>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AllOf<global::G.MetricsData, global::G.ProviderMetricsMetrics> Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderMetrics" /> class.
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="metrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderMetrics(
            string providerName,
            global::G.AllOf<global::G.MetricsData, global::G.ProviderMetricsMetrics> metrics)
        {
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderMetrics" /> class.
        /// </summary>
        public ProviderMetrics()
        {
        }
    }
}