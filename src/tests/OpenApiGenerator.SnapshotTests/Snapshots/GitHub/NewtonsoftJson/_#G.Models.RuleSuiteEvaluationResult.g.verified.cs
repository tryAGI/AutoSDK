//HintName: G.Models.RuleSuiteEvaluationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleSuiteEvaluationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
    }
}