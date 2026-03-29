//HintName: G.Models.Mmr.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Maximal Marginal Relevance (MMR) algorithm for re-ranking the points.
    /// </summary>
    public sealed partial class Mmr
    {
        /// <summary>
        /// Tunable parameter for the MMR algorithm. Determines the balance between diversity and relevance.<br/>
        /// A higher value favors diversity (dissimilarity to selected results), while a lower value favors relevance (similarity to the query vector).<br/>
        /// Must be in the range [0, 1]. Default value is 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diversity")]
        public float? Diversity { get; set; }

        /// <summary>
        /// The maximum number of candidates to consider for re-ranking.<br/>
        /// If not specified, the `limit` value is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates_limit")]
        public int? CandidatesLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Mmr" /> class.
        /// </summary>
        /// <param name="diversity">
        /// Tunable parameter for the MMR algorithm. Determines the balance between diversity and relevance.<br/>
        /// A higher value favors diversity (dissimilarity to selected results), while a lower value favors relevance (similarity to the query vector).<br/>
        /// Must be in the range [0, 1]. Default value is 0.5.
        /// </param>
        /// <param name="candidatesLimit">
        /// The maximum number of candidates to consider for re-ranking.<br/>
        /// If not specified, the `limit` value is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Mmr(
            float? diversity,
            int? candidatesLimit)
        {
            this.Diversity = diversity;
            this.CandidatesLimit = candidatesLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mmr" /> class.
        /// </summary>
        public Mmr()
        {
        }
    }
}