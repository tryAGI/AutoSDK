//HintName: G.Models.ReposUpdateRepoRulesetRequestEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposUpdateRepoRulesetRequestEnforcement
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
    public static class ReposUpdateRepoRulesetRequestEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRepoRulesetRequestEnforcement value)
        {
            return value switch
            {
                ReposUpdateRepoRulesetRequestEnforcement.Disabled => "disabled",
                ReposUpdateRepoRulesetRequestEnforcement.Active => "active",
                ReposUpdateRepoRulesetRequestEnforcement.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRepoRulesetRequestEnforcement ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ReposUpdateRepoRulesetRequestEnforcement.Disabled,
                "active" => ReposUpdateRepoRulesetRequestEnforcement.Active,
                "evaluate" => ReposUpdateRepoRulesetRequestEnforcement.Evaluate,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}