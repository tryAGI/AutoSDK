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
        /// 
        /// </summary>
        Comments,
        /// <summary>
        /// 
        /// </summary>
        Reactions,
        /// <summary>
        /// 
        /// </summary>
        ReactionsPlus1,
        /// <summary>
        /// 
        /// </summary>
        Reactions1,
        /// <summary>
        /// 
        /// </summary>
        ReactionsSmile,
        /// <summary>
        /// 
        /// </summary>
        ReactionsThinkingFace,
        /// <summary>
        /// 
        /// </summary>
        ReactionsHeart,
        /// <summary>
        /// 
        /// </summary>
        ReactionsTada,
        /// <summary>
        /// 
        /// </summary>
        Interactions,
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