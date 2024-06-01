//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewThreadUnresolvedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}