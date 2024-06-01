//HintName: G.Models.RepositoryRuleCommitMessagePatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    public enum RepositoryRuleCommitMessagePatternParametersOperator
    {
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        Regex,
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
                RepositoryRuleCommitMessagePatternParametersOperator.StartsWith => "starts_with",
                RepositoryRuleCommitMessagePatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleCommitMessagePatternParametersOperator.Contains => "contains",
                RepositoryRuleCommitMessagePatternParametersOperator.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitMessagePatternParametersOperator ToEnum(string value)
        {
            return value switch
            {
                "starts_with" => RepositoryRuleCommitMessagePatternParametersOperator.StartsWith,
                "ends_with" => RepositoryRuleCommitMessagePatternParametersOperator.EndsWith,
                "contains" => RepositoryRuleCommitMessagePatternParametersOperator.Contains,
                "regex" => RepositoryRuleCommitMessagePatternParametersOperator.Regex,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}