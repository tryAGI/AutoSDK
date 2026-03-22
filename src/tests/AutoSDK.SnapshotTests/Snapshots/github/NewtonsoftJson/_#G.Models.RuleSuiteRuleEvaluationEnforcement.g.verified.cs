//HintName: G.Models.RuleSuiteRuleEvaluationEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of this rule source.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleSuiteRuleEvaluationEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted ruleset")]
        DeletedRuleset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evaluate")]
        Evaluate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuleSuiteRuleEvaluationEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuiteRuleEvaluationEnforcement value)
        {
            return value switch
            {
                RuleSuiteRuleEvaluationEnforcement.Active => "active",
                RuleSuiteRuleEvaluationEnforcement.DeletedRuleset => "deleted ruleset",
                RuleSuiteRuleEvaluationEnforcement.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuiteRuleEvaluationEnforcement? ToEnum(string value)
        {
            return value switch
            {
                "active" => RuleSuiteRuleEvaluationEnforcement.Active,
                "deleted ruleset" => RuleSuiteRuleEvaluationEnforcement.DeletedRuleset,
                "evaluate" => RuleSuiteRuleEvaluationEnforcement.Evaluate,
                _ => null,
            };
        }
    }
}