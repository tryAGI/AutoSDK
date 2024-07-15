//HintName: G.Models.RuleSuiteRuleEvaluationsEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of this rule source.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleSuiteRuleEvaluationsEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evaluate")]
        Evaluate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted ruleset")]
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