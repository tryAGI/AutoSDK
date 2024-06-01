//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectType
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
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectType.Line => "line",
                WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectType ToEnum(string value)
        {
            return value switch
            {
                "line" => WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectType.Line,
                "file" => WebhookPullRequestReviewThreadResolvedThreadCommentsSubjectType.File,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}