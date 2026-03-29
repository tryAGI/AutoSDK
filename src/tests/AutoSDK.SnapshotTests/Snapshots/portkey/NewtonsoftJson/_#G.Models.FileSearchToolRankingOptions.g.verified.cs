//HintName: G.Models.FileSearchToolRankingOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Ranking options for search.
    /// </summary>
    public sealed partial class FileSearchToolRankingOptions
    {
        /// <summary>
        /// The ranker to use for the file search.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranker")]
        public global::G.FileSearchToolRankingOptionsRanker? Ranker { get; set; }

        /// <summary>
        /// The score threshold for the file search, a number between 0 and 1.<br/>
        /// Numbers closer to 1 will attempt to return only the most relevant<br/>
        /// results, but may return fewer results.<br/>
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
        /// Initializes a new instance of the <see cref="FileSearchToolRankingOptions" /> class.
        /// </summary>
        /// <param name="ranker">
        /// The ranker to use for the file search.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="scoreThreshold">
        /// The score threshold for the file search, a number between 0 and 1.<br/>
        /// Numbers closer to 1 will attempt to return only the most relevant<br/>
        /// results, but may return fewer results.<br/>
        /// Default Value: 0
        /// </param>
        public FileSearchToolRankingOptions(
            global::G.FileSearchToolRankingOptionsRanker? ranker,
            double? scoreThreshold)
        {
            this.Ranker = ranker;
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolRankingOptions" /> class.
        /// </summary>
        public FileSearchToolRankingOptions()
        {
        }
    }
}