//HintName: G.Models.ReactionsListForPullRequestReviewCommentContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForPullRequestReviewCommentContent
    {
        /// <summary>
        /// 
        /// </summary>
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        Minus1,
        /// <summary>
        /// 
        /// </summary>
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        Confused,
        /// <summary>
        /// 
        /// </summary>
        Heart,
        /// <summary>
        /// 
        /// </summary>
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
        /// <summary>
        /// 
        /// </summary>
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
        public static ReactionsListForPullRequestReviewCommentContent ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}