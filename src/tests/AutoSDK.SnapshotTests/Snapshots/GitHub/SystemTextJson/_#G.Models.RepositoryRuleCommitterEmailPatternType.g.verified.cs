//HintName: G.Models.RepositoryRuleCommitterEmailPatternType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleCommitterEmailPatternType
    {
        /// <summary>
        /// 
        /// </summary>
        CommitterEmailPattern,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleCommitterEmailPatternTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCommitterEmailPatternType value)
        {
            return value switch
            {
                RepositoryRuleCommitterEmailPatternType.CommitterEmailPattern => "committer_email_pattern",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCommitterEmailPatternType? ToEnum(string value)
        {
            return value switch
            {
                "committer_email_pattern" => RepositoryRuleCommitterEmailPatternType.CommitterEmailPattern,
                _ => null,
            };
        }
    }
}