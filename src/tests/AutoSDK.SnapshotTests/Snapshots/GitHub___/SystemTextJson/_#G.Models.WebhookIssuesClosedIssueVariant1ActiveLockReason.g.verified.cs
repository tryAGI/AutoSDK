//HintName: G.Models.WebhookIssuesClosedIssueVariant1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueVariant1ActiveLockReason
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
    public static class WebhookIssuesClosedIssueVariant1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1ActiveLockReason.Resolved => "resolved",
                WebhookIssuesClosedIssueVariant1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesClosedIssueVariant1ActiveLockReason.TooHeated => "too heated",
                WebhookIssuesClosedIssueVariant1ActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesClosedIssueVariant1ActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesClosedIssueVariant1ActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesClosedIssueVariant1ActiveLockReason.TooHeated,
                "spam" => WebhookIssuesClosedIssueVariant1ActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}