//HintName: G.Models.EvaluatorConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_code_template")]
        public string? EvaluatorCodeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_llm_template")]
        public string? EvaluatorLlmTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_scoring_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluatorScoringType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorConfig" /> class.
        /// </summary>
        /// <param name="evaluatorScoringType"></param>
        /// <param name="evaluatorCodeTemplate"></param>
        /// <param name="evaluatorLlmTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorConfig(
            string evaluatorScoringType,
            string? evaluatorCodeTemplate,
            string? evaluatorLlmTemplate)
        {
            this.EvaluatorCodeTemplate = evaluatorCodeTemplate;
            this.EvaluatorLlmTemplate = evaluatorLlmTemplate;
            this.EvaluatorScoringType = evaluatorScoringType ?? throw new global::System.ArgumentNullException(nameof(evaluatorScoringType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorConfig" /> class.
        /// </summary>
        public EvaluatorConfig()
        {
        }
    }
}