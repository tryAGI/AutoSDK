//HintName: G.Models.WebhookIssueCommentCreatedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueActiveLockReason
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
    public static class WebhookIssueCommentCreatedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentCreatedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentCreatedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentCreatedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssueCommentCreatedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentCreatedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentCreatedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentCreatedIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}