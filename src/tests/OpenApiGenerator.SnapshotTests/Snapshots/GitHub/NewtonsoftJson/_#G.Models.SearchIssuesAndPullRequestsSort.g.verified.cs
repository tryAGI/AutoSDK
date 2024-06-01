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
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="comments")]
        Comments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions")]
        Reactions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-+1")]
        ReactionsPlus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions--1")]
        Reactions1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-smile")]
        ReactionsSmile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-thinking_face")]
        ReactionsThinkingFace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-heart")]
        ReactionsHeart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reactions-tada")]
        ReactionsTada,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="interactions")]
        Interactions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
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
        public static SearchIssuesAndPullRequestsSort ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}