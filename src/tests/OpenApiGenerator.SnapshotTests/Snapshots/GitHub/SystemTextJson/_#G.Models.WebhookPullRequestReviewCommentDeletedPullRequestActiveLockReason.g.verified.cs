//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewCommentDeletedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}