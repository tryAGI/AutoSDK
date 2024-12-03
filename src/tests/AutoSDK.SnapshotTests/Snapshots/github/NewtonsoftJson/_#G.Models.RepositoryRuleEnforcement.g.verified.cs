//HintName: G.Models.RepositoryRuleEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleEnforcement
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
    public static class RepositoryRuleEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleEnforcement value)
        {
            return value switch
            {
                RepositoryRuleEnforcement.Disabled => "disabled",
                RepositoryRuleEnforcement.Active => "active",
                RepositoryRuleEnforcement.Evaluate => "evaluate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleEnforcement? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => RepositoryRuleEnforcement.Disabled,
                "active" => RepositoryRuleEnforcement.Active,
                "evaluate" => RepositoryRuleEnforcement.Evaluate,
                _ => null,
            };
        }
    }
}