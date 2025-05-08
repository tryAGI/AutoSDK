//HintName: G.Models.RankingOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankingOptions
    {
        /// <summary>
        /// The ranker to use for the file search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranker")]
        public global::G.RankingOptionsRanker? Ranker { get; set; }

        /// <summary>
        /// The score threshold for the file search, a number between 0 and 1. Numbers closer to 1 will attempt to return only the most relevant results, but may return fewer results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingOptions" /> class.
        /// </summary>
        /// <param name="ranker">
        /// The ranker to use for the file search.
        /// </param>
        /// <param name="scoreThreshold">
        /// The score threshold for the file search, a number between 0 and 1. Numbers closer to 1 will attempt to return only the most relevant results, but may return fewer results.
        /// </param>
        public RankingOptions(
            global::G.RankingOptionsRanker? ranker,
            double? scoreThreshold)
        {
            this.Ranker = ranker;
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingOptions" /> class.
        /// </summary>
        public RankingOptions()
        {
        }
    }
}