//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldIssueActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off-topic")]
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too heated")]
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesOpenedChangesOldIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}