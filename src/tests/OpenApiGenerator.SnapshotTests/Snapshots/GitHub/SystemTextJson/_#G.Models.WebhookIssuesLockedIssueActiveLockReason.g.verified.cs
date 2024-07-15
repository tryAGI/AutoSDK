//HintName: G.Models.WebhookIssuesLockedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssueActiveLockReason
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
    public static class WebhookIssuesLockedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesLockedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesLockedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesLockedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesLockedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesLockedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesLockedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesLockedIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}