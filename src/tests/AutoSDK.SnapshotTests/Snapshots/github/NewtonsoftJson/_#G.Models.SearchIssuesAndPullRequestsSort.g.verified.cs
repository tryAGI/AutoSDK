//HintName: G.Models.SearchIssuesAndPullRequestsSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchIssuesAndPullRequestsSort
    {
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="comments")]
        Comments,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="interactions")]
        Interactions,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions")]
        Reactions,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-+1")]
        ReactionsPlus1,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions--1")]
        Reactions1,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-heart")]
        ReactionsHeart,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-smile")]
        ReactionsSmile,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-tada")]
        ReactionsTada,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-thinking_face")]
        ReactionsThinkingFace,
        /// <summary>
        /// [best match](https://docs.github.com/rest/search/search#ranking-search-results)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
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
                SearchIssuesAndPullRequestsSort.Created => "created",
                SearchIssuesAndPullRequestsSort.Interactions => "interactions",
                SearchIssuesAndPullRequestsSort.Reactions => "reactions",
                SearchIssuesAndPullRequestsSort.ReactionsPlus1 => "reactions-+1",
                SearchIssuesAndPullRequestsSort.Reactions1 => "reactions--1",
                SearchIssuesAndPullRequestsSort.ReactionsHeart => "reactions-heart",
                SearchIssuesAndPullRequestsSort.ReactionsSmile => "reactions-smile",
                SearchIssuesAndPullRequestsSort.ReactionsTada => "reactions-tada",
                SearchIssuesAndPullRequestsSort.ReactionsThinkingFace => "reactions-thinking_face",
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
                "created" => SearchIssuesAndPullRequestsSort.Created,
                "interactions" => SearchIssuesAndPullRequestsSort.Interactions,
                "reactions" => SearchIssuesAndPullRequestsSort.Reactions,
                "reactions-+1" => SearchIssuesAndPullRequestsSort.ReactionsPlus1,
                "reactions--1" => SearchIssuesAndPullRequestsSort.Reactions1,
                "reactions-heart" => SearchIssuesAndPullRequestsSort.ReactionsHeart,
                "reactions-smile" => SearchIssuesAndPullRequestsSort.ReactionsSmile,
                "reactions-tada" => SearchIssuesAndPullRequestsSort.ReactionsTada,
                "reactions-thinking_face" => SearchIssuesAndPullRequestsSort.ReactionsThinkingFace,
                "updated" => SearchIssuesAndPullRequestsSort.Updated,
                _ => null,
            };
        }
    }
}