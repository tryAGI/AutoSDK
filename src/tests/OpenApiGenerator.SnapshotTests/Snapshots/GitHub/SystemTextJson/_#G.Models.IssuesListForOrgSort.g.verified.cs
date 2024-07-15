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
    public static class IssuesListForOrgSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForOrgSort value)
        {
            return value switch
            {
                IssuesListForOrgSort.Created => "created",
                IssuesListForOrgSort.Updated => "updated",
                IssuesListForOrgSort.Comments => "comments",
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
                "created" => IssuesListForOrgSort.Created,
                "updated" => IssuesListForOrgSort.Updated,
                "comments" => IssuesListForOrgSort.Comments,
                _ => null,
            };
        }
    }
}