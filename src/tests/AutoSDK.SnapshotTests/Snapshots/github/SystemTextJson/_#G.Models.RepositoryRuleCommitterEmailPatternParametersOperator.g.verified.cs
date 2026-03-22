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
    public static class RepositoryRuleCommitterEmailPatternParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCommitterEmailPatternParametersOperator value)
        {
            return value switch
            {
                RepositoryRuleCommitterEmailPatternParametersOperator.Contains => "contains",
                RepositoryRuleCommitterEmailPatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleCommitterEmailPatternParametersOperator.Regex => "regex",
                RepositoryRuleCommitterEmailPatternParametersOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitterEmailPatternParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => RepositoryRuleCommitterEmailPatternParametersOperator.Contains,
                "ends_with" => RepositoryRuleCommitterEmailPatternParametersOperator.EndsWith,
                "regex" => RepositoryRuleCommitterEmailPatternParametersOperator.Regex,
                "starts_with" => RepositoryRuleCommitterEmailPatternParametersOperator.StartsWith,
                _ => null,
            };
        }
    }
}