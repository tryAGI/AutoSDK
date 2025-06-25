﻿//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}