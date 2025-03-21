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
        [global::Newtonsoft.Json.JsonProperty("ranker")]
        public global::G.FileSearchRanker? Ranker { get; set; }

        /// <summary>
        /// The score threshold for the file search. All values must be a floating point number between 0 and 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public double ScoreThreshold { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public FileSearchRankingOptions(
            double scoreThreshold,
            global::G.FileSearchRanker? ranker)
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