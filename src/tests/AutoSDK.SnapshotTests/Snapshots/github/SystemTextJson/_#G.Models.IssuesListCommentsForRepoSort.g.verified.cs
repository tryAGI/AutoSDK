//HintName: G.Models.IssuesListCommentsForRepoSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum IssuesListCommentsForRepoSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListCommentsForRepoSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListCommentsForRepoSort value)
        {
            return value switch
            {
                IssuesListCommentsForRepoSort.Created => "created",
                IssuesListCommentsForRepoSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListCommentsForRepoSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => IssuesListCommentsForRepoSort.Created,
                "updated" => IssuesListCommentsForRepoSort.Updated,
                _ => null,
            };
        }
    }
}