//HintName: G.Models.LogprobsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Logprobs Result
    /// </summary>
    public sealed partial class LogprobsResult
    {
        /// <summary>
        /// Sum of log probabilities for all tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logProbabilitySum")]
        public float? LogProbabilitySum { get; set; }

        /// <summary>
        /// Length = total number of decoding steps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topCandidates")]
        public global::System.Collections.Generic.IList<global::G.TopCandidates>? TopCandidates { get; set; }

        /// <summary>
        /// Length = total number of decoding steps. The chosen candidates may or may not be in top_candidates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chosenCandidates")]
        public global::System.Collections.Generic.IList<global::G.LogprobsResultCandidate>? ChosenCandidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobsResult" /> class.
        /// </summary>
        /// <param name="logProbabilitySum">
        /// Sum of log probabilities for all tokens.
        /// </param>
        /// <param name="topCandidates">
        /// Length = total number of decoding steps.
        /// </param>
        /// <param name="chosenCandidates">
        /// Length = total number of decoding steps. The chosen candidates may or may not be in top_candidates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogprobsResult(
            float? logProbabilitySum,
            global::System.Collections.Generic.IList<global::G.TopCandidates>? topCandidates,
            global::System.Collections.Generic.IList<global::G.LogprobsResultCandidate>? chosenCandidates)
        {
            this.LogProbabilitySum = logProbabilitySum;
            this.TopCandidates = topCandidates;
            this.ChosenCandidates = chosenCandidates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogprobsResult" /> class.
        /// </summary>
        public LogprobsResult()
        {
        }
    }
}