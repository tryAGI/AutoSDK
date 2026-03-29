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
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ProviderTokens> Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUsageTimeSeriesDataPoint" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="providers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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