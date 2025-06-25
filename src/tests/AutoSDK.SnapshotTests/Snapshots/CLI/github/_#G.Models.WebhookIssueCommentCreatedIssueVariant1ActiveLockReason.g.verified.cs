﻿//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueVariant1ActiveLockReason
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
    public static class WebhookIssueCommentCreatedIssueVariant1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentCreatedIssueVariant1ActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}