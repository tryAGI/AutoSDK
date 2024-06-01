//HintName: G.Models.WebhookIssuesClosedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueActiveLockReason
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
    public static class WebhookIssuesClosedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesClosedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesClosedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesClosedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesClosedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesClosedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesClosedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesClosedIssueActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}