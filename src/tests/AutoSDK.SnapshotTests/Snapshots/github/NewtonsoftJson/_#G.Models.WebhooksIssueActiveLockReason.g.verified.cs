﻿//HintName: G.Models.WebhooksIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssueActiveLockReason
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
    public static class WebhooksIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueActiveLockReason value)
        {
            return value switch
            {
                WebhooksIssueActiveLockReason.Resolved => "resolved",
                WebhooksIssueActiveLockReason.OffTopic => "off-topic",
                WebhooksIssueActiveLockReason.TooHeated => "too heated",
                WebhooksIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhooksIssueActiveLockReason.Resolved,
                "off-topic" => WebhooksIssueActiveLockReason.OffTopic,
                "too heated" => WebhooksIssueActiveLockReason.TooHeated,
                "spam" => WebhooksIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}