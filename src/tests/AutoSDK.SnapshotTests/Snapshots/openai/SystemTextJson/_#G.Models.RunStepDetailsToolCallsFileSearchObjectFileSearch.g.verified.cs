//HintName: G.Models.RunStepDetailsToolCallsFileSearchObjectFileSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For now, this is always going to be an empty object.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFileSearchObjectFileSearch
    {
        /// <summary>
        /// The ranking options for the file search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ranking_options")]
        public global::G.RunStepDetailsToolCallsFileSearchRankingOptionsObject? RankingOptions { get; set; }

        /// <summary>
        /// The results of the file search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.RunStepDetailsToolCallsFileSearchResultObject>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchObjectFileSearch" /> class.
        /// </summary>
        /// <param name="rankingOptions">
        /// The ranking options for the file search.
        /// </param>
        /// <param name="results">
        /// The results of the file search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStepDetailsToolCallsFileSearchObjectFileSearch(
            global::G.RunStepDetailsToolCallsFileSearchRankingOptionsObject? rankingOptions,
            global::System.Collections.Generic.IList<global::G.RunStepDetailsToolCallsFileSearchResultObject>? results)
        {
            this.RankingOptions = rankingOptions;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFileSearchObjectFileSearch" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFileSearchObjectFileSearch()
        {
        }
    }
}