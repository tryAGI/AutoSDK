//HintName: G.Models.RepositoryRulesetEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    /// </summary>
    public enum RepositoryRulesetEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Evaluate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulesetEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetEnforcement value)
        {
            return value switch
            {
                RepositoryRulesetEnforcement.Disabled => "disabled",
                RepositoryRulesetEnforcement.Active => "active",
                RepositoryRulesetEnforcement.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetEnforcement ToEnum(string value)
        {
            return value switch
            {
                "disabled" => RepositoryRulesetEnforcement.Disabled,
                "active" => RepositoryRulesetEnforcement.Active,
                "evaluate" => RepositoryRulesetEnforcement.Evaluate,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}