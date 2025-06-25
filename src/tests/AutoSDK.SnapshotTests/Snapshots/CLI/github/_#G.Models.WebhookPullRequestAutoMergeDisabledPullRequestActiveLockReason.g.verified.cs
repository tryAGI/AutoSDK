﻿//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}