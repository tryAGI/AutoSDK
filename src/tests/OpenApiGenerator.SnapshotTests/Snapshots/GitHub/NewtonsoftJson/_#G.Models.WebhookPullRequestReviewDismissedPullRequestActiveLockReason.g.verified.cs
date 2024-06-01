//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewDismissedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewDismissedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewDismissedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewDismissedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewDismissedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewDismissedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewDismissedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewDismissedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}