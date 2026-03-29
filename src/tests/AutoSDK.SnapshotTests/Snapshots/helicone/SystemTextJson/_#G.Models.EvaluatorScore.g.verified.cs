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
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<double?, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<double?, bool?> Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorScore" /> class.
        /// </summary>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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