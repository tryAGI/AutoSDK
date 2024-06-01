//HintName: G.Models.ReposCreateOrgRulesetRequestEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    /// </summary>
    public enum ReposCreateOrgRulesetRequestEnforcement
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
    public static class ReposCreateOrgRulesetRequestEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateOrgRulesetRequestEnforcement value)
        {
            return value switch
            {
                ReposCreateOrgRulesetRequestEnforcement.Disabled => "disabled",
                ReposCreateOrgRulesetRequestEnforcement.Active => "active",
                ReposCreateOrgRulesetRequestEnforcement.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateOrgRulesetRequestEnforcement ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ReposCreateOrgRulesetRequestEnforcement.Disabled,
                "active" => ReposCreateOrgRulesetRequestEnforcement.Active,
                "evaluate" => ReposCreateOrgRulesetRequestEnforcement.Evaluate,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}