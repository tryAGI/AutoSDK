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
        [global::System.Text.Json.Serialization.JsonPropertyName("ranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileSearchToolRankingOptionsRankerJsonConverter))]
        public global::G.FileSearchToolRankingOptionsRanker? Ranker { get; set; }

        /// <summary>
        /// The score threshold for the file search, a number between 0 and 1.<br/>
        /// Numbers closer to 1 will attempt to return only the most relevant<br/>
        /// results, but may return fewer results.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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