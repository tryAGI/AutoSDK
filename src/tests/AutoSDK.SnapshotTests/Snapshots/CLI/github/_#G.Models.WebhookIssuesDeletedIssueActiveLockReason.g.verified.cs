﻿//HintName: G.Models.WebhookIssuesDeletedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssueActiveLockReason
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
    public static class WebhookIssuesDeletedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesDeletedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesDeletedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesDeletedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesDeletedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesDeletedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesDeletedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesDeletedIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}