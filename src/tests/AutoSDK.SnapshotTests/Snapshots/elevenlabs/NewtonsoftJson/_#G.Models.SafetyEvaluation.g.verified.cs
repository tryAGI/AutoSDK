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
        [global::Newtonsoft.Json.JsonProperty("is_unsafe")]
        public bool? IsUnsafe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_reason")]
        public string? LlmReason { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safety_prompt_version")]
        public int? SafetyPromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("matched_rule_id")]
        public global::System.Collections.Generic.IList<global::G.SafetyRule>? MatchedRuleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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