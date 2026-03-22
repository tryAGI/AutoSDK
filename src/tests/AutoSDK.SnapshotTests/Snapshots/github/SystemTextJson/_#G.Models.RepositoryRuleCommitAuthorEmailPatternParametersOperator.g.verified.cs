//HintName: G.Models.RepositoryRuleCommitAuthorEmailPatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    public enum RepositoryRuleCommitAuthorEmailPatternParametersOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
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
                RepositoryRuleCommitAuthorEmailPatternParametersOperator.Contains => "contains",
                RepositoryRuleCommitAuthorEmailPatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleCommitAuthorEmailPatternParametersOperator.Regex => "regex",
                RepositoryRuleCommitAuthorEmailPatternParametersOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitAuthorEmailPatternParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => RepositoryRuleCommitAuthorEmailPatternParametersOperator.Contains,
                "ends_with" => RepositoryRuleCommitAuthorEmailPatternParametersOperator.EndsWith,
                "regex" => RepositoryRuleCommitAuthorEmailPatternParametersOperator.Regex,
                "starts_with" => RepositoryRuleCommitAuthorEmailPatternParametersOperator.StartsWith,
                _ => null,
            };
        }
    }
}