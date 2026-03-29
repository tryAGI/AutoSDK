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
        [global::Newtonsoft.Json.JsonProperty("evaluator_code_template")]
        public string? EvaluatorCodeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluator_llm_template")]
        public string? EvaluatorLlmTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluator_scoring_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvaluatorScoringType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorConfig" /> class.
        /// </summary>
        /// <param name="evaluatorScoringType"></param>
        /// <param name="evaluatorCodeTemplate"></param>
        /// <param name="evaluatorLlmTemplate"></param>
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