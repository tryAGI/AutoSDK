//HintName: G.Models.RepositoryRuleMergeQueueParametersGroupingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge.
    /// </summary>
    public enum RepositoryRuleMergeQueueParametersGroupingStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        ALLGREEN,
        /// <summary>
        /// 
        /// </summary>
        HEADGREEN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleMergeQueueParametersGroupingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleMergeQueueParametersGroupingStrategy value)
        {
            return value switch
            {
                RepositoryRuleMergeQueueParametersGroupingStrategy.ALLGREEN => "ALLGREEN",
                RepositoryRuleMergeQueueParametersGroupingStrategy.HEADGREEN => "HEADGREEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleMergeQueueParametersGroupingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "ALLGREEN" => RepositoryRuleMergeQueueParametersGroupingStrategy.ALLGREEN,
                "HEADGREEN" => RepositoryRuleMergeQueueParametersGroupingStrategy.HEADGREEN,
                _ => null,
            };
        }
    }
}