//HintName: G.Models.FileSearchServerToolRankingOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileSearchServerToolRankingOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ranker")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FileSearchServerToolRankingOptionsRankerJsonConverter))]
        public global::G.FileSearchServerToolRankingOptionsRanker? Ranker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_threshold")]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchServerToolRankingOptions" /> class.
        /// </summary>
        /// <param name="ranker"></param>
        /// <param name="scoreThreshold"></param>
        public FileSearchServerToolRankingOptions(
            global::G.FileSearchServerToolRankingOptionsRanker? ranker,
            double? scoreThreshold)
        {
            this.Ranker = ranker;
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchServerToolRankingOptions" /> class.
        /// </summary>
        public FileSearchServerToolRankingOptions()
        {
        }
    }
}