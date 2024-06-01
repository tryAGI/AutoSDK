//HintName: G.Models.WebhookIssuesEditedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssueActiveLockReason
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
    public static class WebhookIssuesEditedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesEditedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesEditedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesEditedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesEditedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesEditedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesEditedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesEditedIssueActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}