//HintName: G.Models.RepositoryRuleCommitMessagePatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleCommitMessagePatternParametersOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ends_with")]
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regex")]
        Regex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starts_with")]
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleCommitMessagePatternParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCommitMessagePatternParametersOperator value)
        {
            return value switch
            {
                RepositoryRuleCommitMessagePatternParametersOperator.Contains => "contains",
                RepositoryRuleCommitMessagePatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleCommitMessagePatternParametersOperator.Regex => "regex",
                RepositoryRuleCommitMessagePatternParametersOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitMessagePatternParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => RepositoryRuleCommitMessagePatternParametersOperator.Contains,
                "ends_with" => RepositoryRuleCommitMessagePatternParametersOperator.EndsWith,
                "regex" => RepositoryRuleCommitMessagePatternParametersOperator.Regex,
                "starts_with" => RepositoryRuleCommitMessagePatternParametersOperator.StartsWith,
                _ => null,
            };
        }
    }
}