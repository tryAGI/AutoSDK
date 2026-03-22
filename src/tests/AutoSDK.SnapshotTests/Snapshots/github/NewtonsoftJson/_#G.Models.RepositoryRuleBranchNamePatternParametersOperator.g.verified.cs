//HintName: G.Models.RepositoryRuleBranchNamePatternParametersOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The operator to use for matching.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleBranchNamePatternParametersOperator
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
    public static class RepositoryRuleBranchNamePatternParametersOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleBranchNamePatternParametersOperator value)
        {
            return value switch
            {
                RepositoryRuleBranchNamePatternParametersOperator.Contains => "contains",
                RepositoryRuleBranchNamePatternParametersOperator.EndsWith => "ends_with",
                RepositoryRuleBranchNamePatternParametersOperator.Regex => "regex",
                RepositoryRuleBranchNamePatternParametersOperator.StartsWith => "starts_with",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleBranchNamePatternParametersOperator? ToEnum(string value)
        {
            return value switch
            {
                "contains" => RepositoryRuleBranchNamePatternParametersOperator.Contains,
                "ends_with" => RepositoryRuleBranchNamePatternParametersOperator.EndsWith,
                "regex" => RepositoryRuleBranchNamePatternParametersOperator.Regex,
                "starts_with" => RepositoryRuleBranchNamePatternParametersOperator.StartsWith,
                _ => null,
            };
        }
    }
}