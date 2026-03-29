//HintName: G.Models.ProviderUsageLeaderboardEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderUsageLeaderboardEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rank", Required = global::Newtonsoft.Json.Required.Always)]
        public double Rank { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percentChange")]
        public double? PercentChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUsageLeaderboardEntry" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="provider"></param>
        /// <param name="totalTokens"></param>
        /// <param name="percentChange"></param>
        public ProviderUsageLeaderboardEntry(
            double rank,
            string provider,
            double totalTokens,
            double? percentChange)
        {
            this.Rank = rank;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.TotalTokens = totalTokens;
            this.PercentChange = percentChange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUsageLeaderboardEntry" /> class.
        /// </summary>
        public ProviderUsageLeaderboardEntry()
        {
        }
    }
}