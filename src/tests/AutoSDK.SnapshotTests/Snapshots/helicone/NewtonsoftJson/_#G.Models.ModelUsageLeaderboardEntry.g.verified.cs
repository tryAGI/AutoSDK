//HintName: G.Models.ModelUsageLeaderboardEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelUsageLeaderboardEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rank", Required = global::Newtonsoft.Json.Required.Always)]
        public double Rank { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("percentChange")]
        public double? PercentChange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUsageLeaderboardEntry" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="model"></param>
        /// <param name="author"></param>
        /// <param name="totalTokens"></param>
        /// <param name="percentChange"></param>
        public ModelUsageLeaderboardEntry(
            double rank,
            string model,
            string author,
            double totalTokens,
            double? percentChange)
        {
            this.Rank = rank;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.TotalTokens = totalTokens;
            this.PercentChange = percentChange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUsageLeaderboardEntry" /> class.
        /// </summary>
        public ModelUsageLeaderboardEntry()
        {
        }
    }
}