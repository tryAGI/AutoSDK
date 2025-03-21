//HintName: G.Models.RunStepDetailsToolCallsFileSearchRankingOptionsObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ranking options for the file search.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchRankingOptionsObject
    {
        /// <summary>
        /// The ranker to use for the file search. If not specified will use the `auto` ranker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileSearchRankerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FileSearchRanker Ranker { get; set; }

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
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchRankingOptionsObject" /> class.
        /// </summary>
        /// <param name="ranker">
        /// The ranker to use for the file search. If not specified will use the `auto` ranker.
        /// </param>
        /// <param name="scoreThreshold">
        /// The score threshold for the file search. All values must be a floating point number between 0 and 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDetailsToolCallsFileSearchRankingOptionsObject(
            global::G.FileSearchRanker ranker,
            double scoreThreshold)
        {
            this.Ranker = ranker;
            this.ScoreThreshold = scoreThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchRankingOptionsObject" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFileSearchRankingOptionsObject()
        {
        }
    }
}