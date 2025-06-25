﻿//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewCommentEditedPullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}