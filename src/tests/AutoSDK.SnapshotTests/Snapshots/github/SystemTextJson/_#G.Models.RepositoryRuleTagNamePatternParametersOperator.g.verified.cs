//HintName: G.Models.RepositoryRuleTagNamePatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    public enum RepositoryRuleTagNamePatternParametersOperator
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
    public static class RepositoryRuleTagNamePatternParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleTagNamePatternParametersOperator value)
        {
            return value switch
            {
                RepositoryRuleTagNamePatternParametersOperator.Contains => "contains",
                RepositoryRuleTagNamePatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleTagNamePatternParametersOperator.Regex => "regex",
                RepositoryRuleTagNamePatternParametersOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleTagNamePatternParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => RepositoryRuleTagNamePatternParametersOperator.Contains,
                "ends_with" => RepositoryRuleTagNamePatternParametersOperator.EndsWith,
                "regex" => RepositoryRuleTagNamePatternParametersOperator.Regex,
                "starts_with" => RepositoryRuleTagNamePatternParametersOperator.StartsWith,
                _ => null,
            };
        }
    }
}