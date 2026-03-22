//HintName: G.Models.ReactionsCreateForPullRequestReviewCommentRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the pull request review comment.
    /// </summary>
    public enum ReactionsCreateForPullRequestReviewCommentRequestContent
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
        Confused,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
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
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReactionsCreateForPullRequestReviewCommentRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForPullRequestReviewCommentRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForPullRequestReviewCommentRequestContent.Plus1 => "+1",
                ReactionsCreateForPullRequestReviewCommentRequestContent.Minus1 => "-1",
                ReactionsCreateForPullRequestReviewCommentRequestContent.Confused => "confused",
                ReactionsCreateForPullRequestReviewCommentRequestContent.Eyes => "eyes",
                ReactionsCreateForPullRequestReviewCommentRequestContent.Heart => "heart",
                ReactionsCreateForPullRequestReviewCommentRequestContent.Hooray => "hooray",
                ReactionsCreateForPullRequestReviewCommentRequestContent.Laugh => "laugh",
                ReactionsCreateForPullRequestReviewCommentRequestContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForPullRequestReviewCommentRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForPullRequestReviewCommentRequestContent.Plus1,
                "-1" => ReactionsCreateForPullRequestReviewCommentRequestContent.Minus1,
                "confused" => ReactionsCreateForPullRequestReviewCommentRequestContent.Confused,
                "eyes" => ReactionsCreateForPullRequestReviewCommentRequestContent.Eyes,
                "heart" => ReactionsCreateForPullRequestReviewCommentRequestContent.Heart,
                "hooray" => ReactionsCreateForPullRequestReviewCommentRequestContent.Hooray,
                "laugh" => ReactionsCreateForPullRequestReviewCommentRequestContent.Laugh,
                "rocket" => ReactionsCreateForPullRequestReviewCommentRequestContent.Rocket,
                _ => null,
            };
        }
    }
}