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
        [global::Newtonsoft.Json.JsonProperty("rank", Required = global::Newtonsoft.Json.Required.Always)]
        public double Rank { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public string Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("marketShare", Required = global::Newtonsoft.Json.Required.Always)]
        public double MarketShare { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rankChange")]
        public double? RankChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("marketShareChange")]
        public double? MarketShareChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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