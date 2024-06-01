//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off-topic")]
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too heated")]
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}