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
}