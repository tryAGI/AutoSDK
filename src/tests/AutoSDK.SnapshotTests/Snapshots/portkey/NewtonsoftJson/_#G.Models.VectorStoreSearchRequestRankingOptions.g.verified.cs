//HintName: G.Models.VectorStoreSearchRequestRankingOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Ranking options for search.
    /// </summary>
    public sealed partial class VectorStoreSearchRequestRankingOptions
    {
        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranker")]
        public global::G.VectorStoreSearchRequestRankingOptionsRanker? Ranker { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchRequestRankingOptions" /> class.
        /// </summary>
        /// <param name="ranker">
        /// Default Value: auto
        /// </param>
        /// <param name="scoreThreshold">
        /// Default Value: 0
        /// </param>
        public VectorStoreSearchRequestRankingOptions(
            global::G.VectorStoreSearchRequestRankingOptionsRanker? ranker,
            double? scoreThreshold)
        {
            this.Ranker = ranker;
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchRequestRankingOptions" /> class.
        /// </summary>
        public VectorStoreSearchRequestRankingOptions()
        {
        }
    }
}