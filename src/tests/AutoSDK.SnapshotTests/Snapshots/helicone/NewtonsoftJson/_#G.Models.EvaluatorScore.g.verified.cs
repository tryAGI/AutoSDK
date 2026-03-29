//HintName: G.Models.EvaluatorScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorScore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<double?, bool?> Score { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorScore" /> class.
        /// </summary>
        /// <param name="score"></param>
        public EvaluatorScore(
            global::G.AnyOf<double?, bool?> score)
        {
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorScore" /> class.
        /// </summary>
        public EvaluatorScore()
        {
        }
    }
}