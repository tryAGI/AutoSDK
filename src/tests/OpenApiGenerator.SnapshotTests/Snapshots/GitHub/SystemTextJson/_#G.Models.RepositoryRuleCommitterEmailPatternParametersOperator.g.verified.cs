//HintName: G.Models.RepositoryRuleCommitterEmailPatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    public enum RepositoryRuleCommitterEmailPatternParametersOperator
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
    public static class RepositoryRuleCommitterEmailPatternParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCommitterEmailPatternParametersOperator value)
        {
            return value switch
            {
                RepositoryRuleCommitterEmailPatternParametersOperator.StartsWith => "starts_with",
                RepositoryRuleCommitterEmailPatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleCommitterEmailPatternParametersOperator.Contains => "contains",
                RepositoryRuleCommitterEmailPatternParametersOperator.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitterEmailPatternParametersOperator ToEnum(string value)
        {
            return value switch
            {
                "starts_with" => RepositoryRuleCommitterEmailPatternParametersOperator.StartsWith,
                "ends_with" => RepositoryRuleCommitterEmailPatternParametersOperator.EndsWith,
                "contains" => RepositoryRuleCommitterEmailPatternParametersOperator.Contains,
                "regex" => RepositoryRuleCommitterEmailPatternParametersOperator.Regex,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}