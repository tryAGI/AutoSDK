//HintName: G.Models.FileSearchRankingOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ranking options for the file search. If not specified, the file search tool will use the `auto` ranker and a score_threshold of 0.<br/>
    /// See the [file search tool documentation](/docs/assistants/tools/file-search#customizing-file-search-settings) for more information.
    /// </summary>
    public sealed partial class FileSearchRankingOptions
    {
        /// <summary>
        /// The ranker to use for the file search. If not specified will use the `auto` ranker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileSearchRankingOptionsRankerJsonConverter))]
        public global::G.FileSearchRankingOptionsRanker? Ranker { get; set; }

        /// <summary>
        /// The score threshold for the file search. All values must be a floating point number between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScoreThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchRankingOptions" /> class.
        /// </summary>
        /// <param name="ranker">
        /// The ranker to use for the file search. If not specified will use the `auto` ranker.
        /// </param>
        /// <param name="scoreThreshold">
        /// The score threshold for the file search. All values must be a floating point number between 0 and 1.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FileSearchRankingOptions(
            double scoreThreshold,
            global::G.FileSearchRankingOptionsRanker? ranker)
        {
            this.ScoreThreshold = scoreThreshold;
            this.Ranker = ranker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchRankingOptions" /> class.
        /// </summary>
        public FileSearchRankingOptions()
        {
        }
    }
}