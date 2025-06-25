//HintName: G.Models.WebhookPullRequestReviewCommentCreatedCommentSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedCommentSubjectType
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
    public static class WebhookPullRequestReviewCommentCreatedCommentSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedCommentSubjectType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedCommentSubjectType.Line => "line",
                WebhookPullRequestReviewCommentCreatedCommentSubjectType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedCommentSubjectType? ToEnum(string value)
        {
            return value switch
            {
                "line" => WebhookPullRequestReviewCommentCreatedCommentSubjectType.Line,
                "file" => WebhookPullRequestReviewCommentCreatedCommentSubjectType.File,
                _ => null,
            };
        }
    }
}