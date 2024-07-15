//HintName: G.Models.RuleSuiteRuleEvaluationsEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of this rule source.
    /// </summary>
    public enum RuleSuiteRuleEvaluationsEnforcement
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
    public static class RuleSuiteRuleEvaluationsEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuleSuiteRuleEvaluationsEnforcement value)
        {
            return value switch
            {
                RuleSuiteRuleEvaluationsEnforcement.Active => "active",
                RuleSuiteRuleEvaluationsEnforcement.Evaluate => "evaluate",
                RuleSuiteRuleEvaluationsEnforcement.DeletedRuleset => "deleted ruleset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuleSuiteRuleEvaluationsEnforcement? ToEnum(string value)
        {
            return value switch
            {
                "active" => RuleSuiteRuleEvaluationsEnforcement.Active,
                "evaluate" => RuleSuiteRuleEvaluationsEnforcement.Evaluate,
                "deleted ruleset" => RuleSuiteRuleEvaluationsEnforcement.DeletedRuleset,
                _ => null,
            };
        }
    }
}