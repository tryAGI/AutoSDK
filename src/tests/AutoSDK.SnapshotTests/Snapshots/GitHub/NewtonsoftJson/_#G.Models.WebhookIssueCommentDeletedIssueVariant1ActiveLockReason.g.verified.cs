﻿//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1ActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off-topic")]
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too heated")]
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentDeletedIssueVariant1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentDeletedIssueVariant1ActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}