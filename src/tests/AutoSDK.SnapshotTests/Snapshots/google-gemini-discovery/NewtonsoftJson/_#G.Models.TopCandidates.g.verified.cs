//HintName: G.Models.TopCandidates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Candidates with top log probabilities at each decoding step.
    /// </summary>
    public sealed partial class TopCandidates
    {
        /// <summary>
        /// Sorted by log probability in descending order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidates")]
        public global::System.Collections.Generic.IList<global::G.LogprobsResultCandidate>? Candidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopCandidates" /> class.
        /// </summary>
        /// <param name="candidates">
        /// Sorted by log probability in descending order.
        /// </param>
        public TopCandidates(
            global::System.Collections.Generic.IList<global::G.LogprobsResultCandidate>? candidates)
        {
            this.Candidates = candidates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopCandidates" /> class.
        /// </summary>
        public TopCandidates()
        {
        }
    }
}