//HintName: G.Models.UpdateEvaluatorParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEvaluatorParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_type")]
        public string? ScoringType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_template")]
        public object? LlmTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_template")]
        public object? CodeTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_mile_config")]
        public object? LastMileConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEvaluatorParams" /> class.
        /// </summary>
        /// <param name="scoringType"></param>
        /// <param name="llmTemplate"></param>
        /// <param name="codeTemplate"></param>
        /// <param name="name"></param>
        /// <param name="lastMileConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEvaluatorParams(
            string? scoringType,
            object? llmTemplate,
            object? codeTemplate,
            string? name,
            object? lastMileConfig)
        {
            this.ScoringType = scoringType;
            this.LlmTemplate = llmTemplate;
            this.CodeTemplate = codeTemplate;
            this.Name = name;
            this.LastMileConfig = lastMileConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEvaluatorParams" /> class.
        /// </summary>
        public UpdateEvaluatorParams()
        {
        }
    }
}