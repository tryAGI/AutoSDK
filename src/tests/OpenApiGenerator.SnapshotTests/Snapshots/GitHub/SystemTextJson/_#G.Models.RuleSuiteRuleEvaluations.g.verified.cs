//HintName: G.Models.RuleSuiteRuleEvaluations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RuleSuiteRuleEvaluations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_source")]
        public RuleSuiteRuleEvaluationsRuleSource? RuleSource { get; set; }

        /// <summary>
        /// The enforcement level of this rule source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RuleSuiteRuleEvaluationsEnforcementJsonConverter))]
        public RuleSuiteRuleEvaluationsEnforcement? Enforcement { get; set; }

        /// <summary>
        /// The result of the evaluation of the individual rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RuleSuiteRuleEvaluationsResultJsonConverter))]
        public RuleSuiteRuleEvaluationsResult? Result { get; set; }

        /// <summary>
        /// The type of rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_type")]
        public string? RuleType { get; set; }

        /// <summary>
        /// Any associated details with the rule evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}