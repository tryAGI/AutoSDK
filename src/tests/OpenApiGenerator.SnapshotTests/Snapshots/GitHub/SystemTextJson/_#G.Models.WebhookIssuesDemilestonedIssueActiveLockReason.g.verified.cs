//HintName: G.Models.WebhookIssuesDemilestonedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueActiveLockReason
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
    public static class WebhookIssuesDemilestonedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesDemilestonedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesDemilestonedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesDemilestonedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesDemilestonedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesDemilestonedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesDemilestonedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesDemilestonedIssueActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}