//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewSubmittedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}