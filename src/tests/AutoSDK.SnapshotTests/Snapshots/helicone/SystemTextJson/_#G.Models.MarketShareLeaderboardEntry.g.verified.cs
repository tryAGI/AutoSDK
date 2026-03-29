//HintName: G.Models.MarketShareLeaderboardEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketShareLeaderboardEntry
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
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketShare")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MarketShare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankChange")]
        public double? RankChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketShareChange")]
        public double? MarketShareChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketShareLeaderboardEntry" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="author"></param>
        /// <param name="totalTokens"></param>
        /// <param name="marketShare"></param>
        /// <param name="rankChange"></param>
        /// <param name="marketShareChange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarketShareLeaderboardEntry(
            double rank,
            string author,
            double totalTokens,
            double marketShare,
            double? rankChange,
            double? marketShareChange)
        {
            this.Rank = rank;
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.TotalTokens = totalTokens;
            this.MarketShare = marketShare;
            this.RankChange = rankChange;
            this.MarketShareChange = marketShareChange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketShareLeaderboardEntry" /> class.
        /// </summary>
        public MarketShareLeaderboardEntry()
        {
        }
    }
}