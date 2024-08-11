//HintName: G.Models.RuleSuiteRuleEvaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RuleSuiteRuleEvaluation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule_source")]
        public global::G.RuleSuiteRuleEvaluationRuleSource? RuleSource { get; set; }

        /// <summary>
        /// The enforcement level of this rule source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforcement")]
        public global::G.RuleSuiteRuleEvaluationEnforcement? Enforcement { get; set; }

        /// <summary>
        /// The result of the evaluation of the individual rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.RuleSuiteRuleEvaluationResult? Result { get; set; }

        /// <summary>
        /// The type of rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule_type")]
        public string? RuleType { get; set; }

        /// <summary>
        /// Any associated details with the rule evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}