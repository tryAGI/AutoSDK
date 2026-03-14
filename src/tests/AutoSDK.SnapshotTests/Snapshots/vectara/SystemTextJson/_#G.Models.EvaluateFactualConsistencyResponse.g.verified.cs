//HintName: G.Models.EvaluateFactualConsistencyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results of the factual consistency evaluation.
    /// </summary>
    public sealed partial class EvaluateFactualConsistencyResponse
    {
        /// <summary>
        /// A prediction score that must be greater than 0 but less than 1 from HHEM, monotonically indicates the likelihood of hallucinations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateFactualConsistencyResponse" /> class.
        /// </summary>
        /// <param name="score">
        /// A prediction score that must be greater than 0 but less than 1 from HHEM, monotonically indicates the likelihood of hallucinations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluateFactualConsistencyResponse(
            double score)
        {
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateFactualConsistencyResponse" /> class.
        /// </summary>
        public EvaluateFactualConsistencyResponse()
        {
        }
    }
}