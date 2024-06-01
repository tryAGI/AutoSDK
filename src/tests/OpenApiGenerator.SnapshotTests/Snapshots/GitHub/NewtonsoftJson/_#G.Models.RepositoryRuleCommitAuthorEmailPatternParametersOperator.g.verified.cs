//HintName: G.Models.RepositoryRuleCommitAuthorEmailPatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleCommitAuthorEmailPatternParametersOperator
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleCommitAuthorEmailPatternParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCommitAuthorEmailPatternParametersOperator value)
        {
            return value switch
            {
                RepositoryRuleCommitAuthorEmailPatternParametersOperator.StartsWith => "starts_with",
                RepositoryRuleCommitAuthorEmailPatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleCommitAuthorEmailPatternParametersOperator.Contains => "contains",
                RepositoryRuleCommitAuthorEmailPatternParametersOperator.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitAuthorEmailPatternParametersOperator ToEnum(string value)
        {
            return value switch
            {
                "starts_with" => RepositoryRuleCommitAuthorEmailPatternParametersOperator.StartsWith,
                "ends_with" => RepositoryRuleCommitAuthorEmailPatternParametersOperator.EndsWith,
                "contains" => RepositoryRuleCommitAuthorEmailPatternParametersOperator.Contains,
                "regex" => RepositoryRuleCommitAuthorEmailPatternParametersOperator.Regex,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}