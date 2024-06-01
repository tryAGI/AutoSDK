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