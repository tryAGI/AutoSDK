//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType.Line => "line",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType? ToEnum(string value)
        {
            return value switch
            {
                "line" => WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType.Line,
                "file" => WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType.File,
                _ => null,
            };
        }
    }
}