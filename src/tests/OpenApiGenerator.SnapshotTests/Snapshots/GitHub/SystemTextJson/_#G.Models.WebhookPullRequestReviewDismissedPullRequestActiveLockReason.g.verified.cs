//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
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
        public static WebhookPullRequestReviewDismissedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewDismissedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewDismissedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewDismissedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewDismissedPullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}