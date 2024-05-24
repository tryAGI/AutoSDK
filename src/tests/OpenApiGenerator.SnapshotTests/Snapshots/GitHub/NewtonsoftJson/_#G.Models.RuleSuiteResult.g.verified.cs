//HintName: G.Models.RuleSuiteResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the rule evaluations for rules with the `active` enforcement status.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RuleSuiteResult
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bypass")]
        Bypass,
    }
}