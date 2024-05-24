//HintName: G.Models.RepositoryRulesetEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulesetEnforcement
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
}