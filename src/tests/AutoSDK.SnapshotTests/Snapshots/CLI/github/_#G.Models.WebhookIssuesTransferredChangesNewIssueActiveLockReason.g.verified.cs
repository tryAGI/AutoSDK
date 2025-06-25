//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssueActiveLockReason
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
    public static class WebhookIssuesTransferredChangesNewIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}