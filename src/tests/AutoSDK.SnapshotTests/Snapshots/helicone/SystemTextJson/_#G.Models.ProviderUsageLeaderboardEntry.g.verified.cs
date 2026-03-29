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
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentChange")]
        public double? PercentChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderUsageLeaderboardEntry" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="provider"></param>
        /// <param name="totalTokens"></param>
        /// <param name="percentChange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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