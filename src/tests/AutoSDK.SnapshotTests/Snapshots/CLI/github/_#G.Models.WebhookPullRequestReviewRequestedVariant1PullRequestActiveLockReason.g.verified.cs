﻿//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewRequestedVariant1PullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}