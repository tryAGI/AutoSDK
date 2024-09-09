//HintName: G.Models.IssuesListForRepoSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum IssuesListForRepoSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
        /// <summary>
        /// 
        /// </summary>
        Comments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListForRepoSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForRepoSort value)
        {
            return value switch
            {
                IssuesListForRepoSort.Created => "created",
                IssuesListForRepoSort.Updated => "updated",
                IssuesListForRepoSort.Comments => "comments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForRepoSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => IssuesListForRepoSort.Created,
                "updated" => IssuesListForRepoSort.Updated,
                "comments" => IssuesListForRepoSort.Comments,
                _ => null,
            };
        }
    }
}