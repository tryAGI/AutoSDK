//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThreadCommentSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedThreadCommentSide
    {
        /// <summary>
        /// 
        /// </summary>
        LEFT,
        /// <summary>
        /// 
        /// </summary>
        RIGHT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedThreadCommentSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedThreadCommentSide value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedThreadCommentSide.LEFT => "LEFT",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedThreadCommentSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => WebhookPullRequestReviewThreadUnresolvedThreadCommentSide.LEFT,
                "RIGHT" => WebhookPullRequestReviewThreadUnresolvedThreadCommentSide.RIGHT,
                _ => null,
            };
        }
    }
}