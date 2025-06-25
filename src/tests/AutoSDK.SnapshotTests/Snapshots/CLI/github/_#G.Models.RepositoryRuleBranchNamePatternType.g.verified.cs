//HintName: G.Models.RepositoryRuleBranchNamePatternType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleBranchNamePatternType
    {
        /// <summary>
        /// 
        /// </summary>
        BranchNamePattern,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleBranchNamePatternTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleBranchNamePatternType value)
        {
            return value switch
            {
                RepositoryRuleBranchNamePatternType.BranchNamePattern => "branch_name_pattern",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleBranchNamePatternType? ToEnum(string value)
        {
            return value switch
            {
                "branch_name_pattern" => RepositoryRuleBranchNamePatternType.BranchNamePattern,
                _ => null,
            };
        }
    }
}