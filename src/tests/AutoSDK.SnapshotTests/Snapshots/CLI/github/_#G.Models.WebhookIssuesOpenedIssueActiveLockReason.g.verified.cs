//HintName: G.Models.WebhookIssuesOpenedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssueActiveLockReason
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
    public static class WebhookIssuesOpenedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesOpenedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesOpenedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesOpenedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesOpenedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesOpenedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesOpenedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesOpenedIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}