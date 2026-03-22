//HintName: G.Models.IssuesListForOrgSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum IssuesListForOrgSort
    {
        /// <summary>
        /// 
        /// </summary>
        Comments,
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
    public static class IssuesListForOrgSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForOrgSort value)
        {
            return value switch
            {
                IssuesListForOrgSort.Comments => "comments",
                IssuesListForOrgSort.Created => "created",
                IssuesListForOrgSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForOrgSort? ToEnum(string value)
        {
            return value switch
            {
                "comments" => IssuesListForOrgSort.Comments,
                "created" => IssuesListForOrgSort.Created,
                "updated" => IssuesListForOrgSort.Updated,
                _ => null,
            };
        }
    }
}