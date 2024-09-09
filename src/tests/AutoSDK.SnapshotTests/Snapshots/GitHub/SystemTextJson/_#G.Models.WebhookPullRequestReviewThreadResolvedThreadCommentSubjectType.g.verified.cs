//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentSubjectType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentSubjectType.Line => "line",
                WebhookPullRequestReviewThreadResolvedThreadCommentSubjectType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentSubjectType? ToEnum(string value)
        {
            return value switch
            {
                "line" => WebhookPullRequestReviewThreadResolvedThreadCommentSubjectType.Line,
                "file" => WebhookPullRequestReviewThreadResolvedThreadCommentSubjectType.File,
                _ => null,
            };
        }
    }
}