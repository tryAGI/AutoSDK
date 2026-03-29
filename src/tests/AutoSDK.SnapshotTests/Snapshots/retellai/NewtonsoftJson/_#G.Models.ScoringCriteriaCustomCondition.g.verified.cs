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
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double ScoreWeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoringCriteriaCustomCondition" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="scoreWeight"></param>
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