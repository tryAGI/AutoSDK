//HintName: G.Models.WebhookIssueCommentDeletedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueActiveLockReason
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
    public static class WebhookIssueCommentDeletedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentDeletedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentDeletedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentDeletedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssueCommentDeletedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentDeletedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentDeletedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentDeletedIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}