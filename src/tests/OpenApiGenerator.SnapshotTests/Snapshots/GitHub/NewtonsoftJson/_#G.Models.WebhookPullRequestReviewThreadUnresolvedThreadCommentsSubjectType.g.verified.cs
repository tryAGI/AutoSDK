//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectType
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
    public static class WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectType.Line => "line",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectType ToEnum(string value)
        {
            return value switch
            {
                "line" => WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectType.Line,
                "file" => WebhookPullRequestReviewThreadUnresolvedThreadCommentsSubjectType.File,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}