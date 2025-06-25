﻿//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewRequestedVariant2PullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}