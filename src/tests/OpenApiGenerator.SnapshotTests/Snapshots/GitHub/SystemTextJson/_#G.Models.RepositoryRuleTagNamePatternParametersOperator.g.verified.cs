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
    public static class RepositoryRuleTagNamePatternParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleTagNamePatternParametersOperator value)
        {
            return value switch
            {
                RepositoryRuleTagNamePatternParametersOperator.StartsWith => "starts_with",
                RepositoryRuleTagNamePatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleTagNamePatternParametersOperator.Contains => "contains",
                RepositoryRuleTagNamePatternParametersOperator.Regex => "regex",
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
                "starts_with" => RepositoryRuleTagNamePatternParametersOperator.StartsWith,
                "ends_with" => RepositoryRuleTagNamePatternParametersOperator.EndsWith,
                "contains" => RepositoryRuleTagNamePatternParametersOperator.Contains,
                "regex" => RepositoryRuleTagNamePatternParametersOperator.Regex,
                _ => null,
            };
        }
    }
}