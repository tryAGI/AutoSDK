//HintName: G.Models.RepositoryRuleCommitterEmailPatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleCommitterEmailPatternParametersOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starts_with")]
        StartsWith,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ends_with")]
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regex")]
        Regex,
    }
}