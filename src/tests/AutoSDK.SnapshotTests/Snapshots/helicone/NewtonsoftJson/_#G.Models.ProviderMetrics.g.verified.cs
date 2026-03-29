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
        [global::Newtonsoft.Json.JsonProperty("providerName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AllOf<global::G.MetricsData, global::G.ProviderMetricsMetrics> Metrics { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderMetrics" /> class.
        /// </summary>
        /// <param name="providerName"></param>
        /// <param name="metrics"></param>
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