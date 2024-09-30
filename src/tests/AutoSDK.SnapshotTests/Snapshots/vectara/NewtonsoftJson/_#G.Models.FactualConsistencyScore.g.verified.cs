//HintName: G.Models.FactualConsistencyScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event containing the factual consistency score.
    /// </summary>
    public sealed partial class FactualConsistencyScore
    {
        /// <summary>
        /// When the streaming event contains the factual consistency score, the<br/>
        /// type will be `factual_consistency_score`.<br/>
        /// Default Value: factual_consistency_score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; } = "factual_consistency_score";

        /// <summary>
        /// The probability that the summary is factually consistent with the results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("factual_consistency_score")]
        public float? FactualConsistencyScore1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}