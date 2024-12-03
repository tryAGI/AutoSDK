//HintName: G.Models.SearchIssuesAndPullRequestsSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchIssuesAndPullRequestsSort
    {
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        Comments,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        Reactions,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        ReactionsPlus1,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        Reactions1,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        ReactionsSmile,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        ReactionsThinkingFace,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        ReactionsHeart,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        ReactionsTada,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        Interactions,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        Created,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchIssuesAndPullRequestsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchIssuesAndPullRequestsSort value)
        {
            return value switch
            {
                SearchIssuesAndPullRequestsSort.Comments => "comments",
                SearchIssuesAndPullRequestsSort.Reactions => "reactions",
                SearchIssuesAndPullRequestsSort.ReactionsPlus1 => "reactions-+1",
                SearchIssuesAndPullRequestsSort.Reactions1 => "reactions--1",
                SearchIssuesAndPullRequestsSort.ReactionsSmile => "reactions-smile",
                SearchIssuesAndPullRequestsSort.ReactionsThinkingFace => "reactions-thinking_face",
                SearchIssuesAndPullRequestsSort.ReactionsHeart => "reactions-heart",
                SearchIssuesAndPullRequestsSort.ReactionsTada => "reactions-tada",
                SearchIssuesAndPullRequestsSort.Interactions => "interactions",
                SearchIssuesAndPullRequestsSort.Created => "created",
                SearchIssuesAndPullRequestsSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchIssuesAndPullRequestsSort? ToEnum(string value)
        {
            return value switch
            {
                "comments" => SearchIssuesAndPullRequestsSort.Comments,
                "reactions" => SearchIssuesAndPullRequestsSort.Reactions,
                "reactions-+1" => SearchIssuesAndPullRequestsSort.ReactionsPlus1,
                "reactions--1" => SearchIssuesAndPullRequestsSort.Reactions1,
                "reactions-smile" => SearchIssuesAndPullRequestsSort.ReactionsSmile,
                "reactions-thinking_face" => SearchIssuesAndPullRequestsSort.ReactionsThinkingFace,
                "reactions-heart" => SearchIssuesAndPullRequestsSort.ReactionsHeart,
                "reactions-tada" => SearchIssuesAndPullRequestsSort.ReactionsTada,
                "interactions" => SearchIssuesAndPullRequestsSort.Interactions,
                "created" => SearchIssuesAndPullRequestsSort.Created,
                "updated" => SearchIssuesAndPullRequestsSort.Updated,
                _ => null,
            };
        }
    }
}