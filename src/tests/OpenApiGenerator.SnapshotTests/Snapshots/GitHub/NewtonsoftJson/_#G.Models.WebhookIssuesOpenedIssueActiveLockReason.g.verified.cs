//HintName: G.Models.WebhookIssuesOpenedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedIssueActiveLockReason
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
        public static WebhookIssuesOpenedIssueActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesOpenedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesOpenedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesOpenedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesOpenedIssueActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}