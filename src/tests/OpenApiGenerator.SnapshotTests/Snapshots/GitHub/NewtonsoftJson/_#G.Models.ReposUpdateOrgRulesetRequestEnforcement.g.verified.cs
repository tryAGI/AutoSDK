//HintName: G.Models.ReposUpdateOrgRulesetRequestEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposUpdateOrgRulesetRequestEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateOrgRulesetRequestEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateOrgRulesetRequestEnforcement value)
        {
            return value switch
            {
                ReposUpdateOrgRulesetRequestEnforcement.Disabled => "disabled",
                ReposUpdateOrgRulesetRequestEnforcement.Active => "active",
                ReposUpdateOrgRulesetRequestEnforcement.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateOrgRulesetRequestEnforcement ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ReposUpdateOrgRulesetRequestEnforcement.Disabled,
                "active" => ReposUpdateOrgRulesetRequestEnforcement.Active,
                "evaluate" => ReposUpdateOrgRulesetRequestEnforcement.Evaluate,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}