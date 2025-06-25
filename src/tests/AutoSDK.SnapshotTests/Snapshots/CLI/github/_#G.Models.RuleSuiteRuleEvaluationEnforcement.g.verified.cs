//HintName: G.Models.RuleSuiteRuleEvaluationEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of this rule source.
    /// </summary>
    public enum RuleSuiteRuleEvaluationEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Evaluate,
        /// <summary>
        /// 
        /// </summary>
        DeletedRuleset,
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
                RuleSuiteRuleEvaluationEnforcement.Evaluate => "evaluate",
                RuleSuiteRuleEvaluationEnforcement.DeletedRuleset => "deleted ruleset",
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
                "evaluate" => RuleSuiteRuleEvaluationEnforcement.Evaluate,
                "deleted ruleset" => RuleSuiteRuleEvaluationEnforcement.DeletedRuleset,
                _ => null,
            };
        }
    }
}