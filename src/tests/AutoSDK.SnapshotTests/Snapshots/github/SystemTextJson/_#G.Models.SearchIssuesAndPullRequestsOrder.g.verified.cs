//HintName: G.Models.SearchIssuesAndPullRequestsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SearchIssuesAndPullRequestsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchIssuesAndPullRequestsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchIssuesAndPullRequestsOrder value)
        {
            return value switch
            {
                SearchIssuesAndPullRequestsOrder.Asc => "asc",
                SearchIssuesAndPullRequestsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchIssuesAndPullRequestsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SearchIssuesAndPullRequestsOrder.Asc,
                "desc" => SearchIssuesAndPullRequestsOrder.Desc,
                _ => null,
            };
        }
    }
}