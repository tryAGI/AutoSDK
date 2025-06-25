﻿//HintName: G.Models.WebhooksIssue2ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2ActiveLockReason
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
    public static class WebhooksIssue2ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2ActiveLockReason value)
        {
            return value switch
            {
                WebhooksIssue2ActiveLockReason.Resolved => "resolved",
                WebhooksIssue2ActiveLockReason.OffTopic => "off-topic",
                WebhooksIssue2ActiveLockReason.TooHeated => "too heated",
                WebhooksIssue2ActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhooksIssue2ActiveLockReason.Resolved,
                "off-topic" => WebhooksIssue2ActiveLockReason.OffTopic,
                "too heated" => WebhooksIssue2ActiveLockReason.TooHeated,
                "spam" => WebhooksIssue2ActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}