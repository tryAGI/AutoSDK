//HintName: G.Models.ProviderUsageTimeSeriesDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderUsageTimeSeriesDataPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public string Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProviderTokens> Providers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUsageTimeSeriesDataPoint" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="providers"></param>
        public ProviderUsageTimeSeriesDataPoint(
            string time,
            global::System.Collections.Generic.IList<global::G.ProviderTokens> providers)
        {
            this.Time = time ?? throw new global::System.ArgumentNullException(nameof(time));
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUsageTimeSeriesDataPoint" /> class.
        /// </summary>
        public ProviderUsageTimeSeriesDataPoint()
        {
        }
    }
}