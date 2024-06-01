//HintName: G.Models.WebhookIssuesUnlockedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssueActiveLockReason
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
    public static class WebhookIssuesUnlockedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesUnlockedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesUnlockedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesUnlockedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesUnlockedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesUnlockedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesUnlockedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesUnlockedIssueActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}