//HintName: G.Models.RepositoryRuleMergeQueueParametersMergeMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Method to use when merging changes from queued pull requests.
    /// </summary>
    public enum RepositoryRuleMergeQueueParametersMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        MERGE,
        /// <summary>
        /// 
        /// </summary>
        SQUASH,
        /// <summary>
        /// 
        /// </summary>
        REBASE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleMergeQueueParametersMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleMergeQueueParametersMergeMethod value)
        {
            return value switch
            {
                RepositoryRuleMergeQueueParametersMergeMethod.MERGE => "MERGE",
                RepositoryRuleMergeQueueParametersMergeMethod.SQUASH => "SQUASH",
                RepositoryRuleMergeQueueParametersMergeMethod.REBASE => "REBASE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleMergeQueueParametersMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "MERGE" => RepositoryRuleMergeQueueParametersMergeMethod.MERGE,
                "SQUASH" => RepositoryRuleMergeQueueParametersMergeMethod.SQUASH,
                "REBASE" => RepositoryRuleMergeQueueParametersMergeMethod.REBASE,
                _ => null,
            };
        }
    }
}