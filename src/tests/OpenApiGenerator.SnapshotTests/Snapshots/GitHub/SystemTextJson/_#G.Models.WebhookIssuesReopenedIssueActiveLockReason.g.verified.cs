//HintName: G.Models.WebhookIssuesReopenedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssueActiveLockReason
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
    public static class WebhookIssuesReopenedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesReopenedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesReopenedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesReopenedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesReopenedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesReopenedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesReopenedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesReopenedIssueActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}