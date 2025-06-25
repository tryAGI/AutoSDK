//HintName: G.Models.SafetyEvaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Safety evaluation of the agent. Prompt and first message is taken into account.<br/>
    /// The unsafe reason is provided from the evaluation
    /// </summary>
    public sealed partial class SafetyEvaluation
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_unsafe")]
        public bool? IsUnsafe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_reason")]
        public string? LlmReason { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_prompt_version")]
        public int? SafetyPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matched_rule_id")]
        public global::System.Collections.Generic.IList<global::G.SafetyRule>? MatchedRuleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyEvaluation" /> class.
        /// </summary>
        /// <param name="isUnsafe">
        /// Default Value: false
        /// </param>
        /// <param name="llmReason"></param>
        /// <param name="safetyPromptVersion">
        /// Default Value: 0
        /// </param>
        /// <param name="matchedRuleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetyEvaluation(
            bool? isUnsafe,
            string? llmReason,
            int? safetyPromptVersion,
            global::System.Collections.Generic.IList<global::G.SafetyRule>? matchedRuleId)
        {
            this.IsUnsafe = isUnsafe;
            this.LlmReason = llmReason;
            this.SafetyPromptVersion = safetyPromptVersion;
            this.MatchedRuleId = matchedRuleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyEvaluation" /> class.
        /// </summary>
        public SafetyEvaluation()
        {
        }
    }
}