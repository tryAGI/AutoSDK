//HintName: G.Models.ReactionsListForPullRequestReviewCommentContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsListForPullRequestReviewCommentContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="+1")]
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="-1")]
        Minus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="laugh")]
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="confused")]
        Confused,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heart")]
        Heart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hooray")]
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rocket")]
        Rocket,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eyes")]
        Eyes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReactionsListForPullRequestReviewCommentContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForPullRequestReviewCommentContent value)
        {
            return value switch
            {
                ReactionsListForPullRequestReviewCommentContent.Plus1 => "+1",
                ReactionsListForPullRequestReviewCommentContent.Minus1 => "-1",
                ReactionsListForPullRequestReviewCommentContent.Laugh => "laugh",
                ReactionsListForPullRequestReviewCommentContent.Confused => "confused",
                ReactionsListForPullRequestReviewCommentContent.Heart => "heart",
                ReactionsListForPullRequestReviewCommentContent.Hooray => "hooray",
                ReactionsListForPullRequestReviewCommentContent.Rocket => "rocket",
                ReactionsListForPullRequestReviewCommentContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForPullRequestReviewCommentContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForPullRequestReviewCommentContent.Plus1,
                "-1" => ReactionsListForPullRequestReviewCommentContent.Minus1,
                "laugh" => ReactionsListForPullRequestReviewCommentContent.Laugh,
                "confused" => ReactionsListForPullRequestReviewCommentContent.Confused,
                "heart" => ReactionsListForPullRequestReviewCommentContent.Heart,
                "hooray" => ReactionsListForPullRequestReviewCommentContent.Hooray,
                "rocket" => ReactionsListForPullRequestReviewCommentContent.Rocket,
                "eyes" => ReactionsListForPullRequestReviewCommentContent.Eyes,
                _ => null,
            };
        }
    }
}