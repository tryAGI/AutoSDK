//HintName: G.Models.CohortAggregatedResultTopRecommendation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohortAggregatedResultTopRecommendation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResultTopRecommendation" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohortAggregatedResultTopRecommendation(
            string text,
            double count)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohortAggregatedResultTopRecommendation" /> class.
        /// </summary>
        public CohortAggregatedResultTopRecommendation()
        {
        }
    }
}