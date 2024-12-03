//HintName: G.Models.IssuesListForAuthenticatedUserSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum IssuesListForAuthenticatedUserSort
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
    public static class IssuesListForAuthenticatedUserSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForAuthenticatedUserSort value)
        {
            return value switch
            {
                IssuesListForAuthenticatedUserSort.Created => "created",
                IssuesListForAuthenticatedUserSort.Updated => "updated",
                IssuesListForAuthenticatedUserSort.Comments => "comments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForAuthenticatedUserSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => IssuesListForAuthenticatedUserSort.Created,
                "updated" => IssuesListForAuthenticatedUserSort.Updated,
                "comments" => IssuesListForAuthenticatedUserSort.Comments,
                _ => null,
            };
        }
    }
}