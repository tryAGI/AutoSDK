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
        File,
        /// <summary>
        /// 
        /// </summary>
        Line,
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
                WebhookPullRequestReviewCommentCreatedCommentSubjectType.File => "file",
                WebhookPullRequestReviewCommentCreatedCommentSubjectType.Line => "line",
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
                "file" => WebhookPullRequestReviewCommentCreatedCommentSubjectType.File,
                "line" => WebhookPullRequestReviewCommentCreatedCommentSubjectType.Line,
                _ => null,
            };
        }
    }
}