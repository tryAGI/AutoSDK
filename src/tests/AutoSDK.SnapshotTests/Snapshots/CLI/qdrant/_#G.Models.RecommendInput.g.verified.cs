//HintName: G.Models.RecommendInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecommendInput
    {
        /// <summary>
        /// Look for vectors closest to the vectors from these points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive")]
        public global::System.Collections.Generic.IList<global::G.VectorInput>? Positive { get; set; }

        /// <summary>
        /// Try to avoid vectors like the vector from these points
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative")]
        public global::System.Collections.Generic.IList<global::G.VectorInput>? Negative { get; set; }

        /// <summary>
        /// How to use the provided vectors to find the results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        public global::G.RecommendStrategy? Strategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendInput" /> class.
        /// </summary>
        /// <param name="positive">
        /// Look for vectors closest to the vectors from these points
        /// </param>
        /// <param name="negative">
        /// Try to avoid vectors like the vector from these points
        /// </param>
        /// <param name="strategy">
        /// How to use the provided vectors to find the results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecommendInput(
            global::System.Collections.Generic.IList<global::G.VectorInput>? positive,
            global::System.Collections.Generic.IList<global::G.VectorInput>? negative,
            global::G.RecommendStrategy? strategy)
        {
            this.Positive = positive;
            this.Negative = negative;
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendInput" /> class.
        /// </summary>
        public RecommendInput()
        {
        }
    }
}