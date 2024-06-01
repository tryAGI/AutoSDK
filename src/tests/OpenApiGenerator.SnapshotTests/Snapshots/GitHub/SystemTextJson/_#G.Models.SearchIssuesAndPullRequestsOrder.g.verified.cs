//HintName: G.Models.SearchIssuesAndPullRequestsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum SearchIssuesAndPullRequestsOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Desc,
        /// <summary>
        /// 
        /// </summary>
        Asc,
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
                SearchIssuesAndPullRequestsOrder.Desc => "desc",
                SearchIssuesAndPullRequestsOrder.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchIssuesAndPullRequestsOrder ToEnum(string value)
        {
            return value switch
            {
                "desc" => SearchIssuesAndPullRequestsOrder.Desc,
                "asc" => SearchIssuesAndPullRequestsOrder.Asc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}