//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1ActiveLockReason
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
    public static class WebhookIssueCommentEditedIssueVariant1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentEditedIssueVariant1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentEditedIssueVariant1ActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentEditedIssueVariant1ActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssueCommentEditedIssueVariant1ActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentEditedIssueVariant1ActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentEditedIssueVariant1ActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentEditedIssueVariant1ActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}