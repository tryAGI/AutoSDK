//HintName: G.Models.ScoringCriteriaCustomCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoringCriteriaCustomCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScoreWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoringCriteriaCustomCondition" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="scoreWeight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoringCriteriaCustomCondition(
            string description,
            double scoreWeight)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ScoreWeight = scoreWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoringCriteriaCustomCondition" /> class.
        /// </summary>
        public ScoringCriteriaCustomCondition()
        {
        }
    }
}