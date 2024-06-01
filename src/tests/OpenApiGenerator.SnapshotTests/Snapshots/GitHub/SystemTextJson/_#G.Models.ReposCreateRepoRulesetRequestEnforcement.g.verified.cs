//HintName: G.Models.ReposCreateRepoRulesetRequestEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    /// </summary>
    public enum ReposCreateRepoRulesetRequestEnforcement
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
    public static class ReposCreateRepoRulesetRequestEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateRepoRulesetRequestEnforcement value)
        {
            return value switch
            {
                ReposCreateRepoRulesetRequestEnforcement.Disabled => "disabled",
                ReposCreateRepoRulesetRequestEnforcement.Active => "active",
                ReposCreateRepoRulesetRequestEnforcement.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateRepoRulesetRequestEnforcement ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ReposCreateRepoRulesetRequestEnforcement.Disabled,
                "active" => ReposCreateRepoRulesetRequestEnforcement.Active,
                "evaluate" => ReposCreateRepoRulesetRequestEnforcement.Evaluate,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}