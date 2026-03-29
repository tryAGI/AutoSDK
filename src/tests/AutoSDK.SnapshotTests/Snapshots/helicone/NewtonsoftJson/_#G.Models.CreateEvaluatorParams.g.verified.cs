//HintName: G.Models.CreateEvaluatorParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvaluatorParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scoring_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ScoringType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_template")]
        public object? LlmTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_template")]
        public object? CodeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_mile_config")]
        public object? LastMileConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluatorParams" /> class.
        /// </summary>
        /// <param name="scoringType"></param>
        /// <param name="name"></param>
        /// <param name="llmTemplate"></param>
        /// <param name="codeTemplate"></param>
        /// <param name="lastMileConfig"></param>
        public CreateEvaluatorParams(
            string scoringType,
            string name,
            object? llmTemplate,
            object? codeTemplate,
            object? lastMileConfig)
        {
            this.ScoringType = scoringType ?? throw new global::System.ArgumentNullException(nameof(scoringType));
            this.LlmTemplate = llmTemplate;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CodeTemplate = codeTemplate;
            this.LastMileConfig = lastMileConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvaluatorParams" /> class.
        /// </summary>
        public CreateEvaluatorParams()
        {
        }
    }
}