//HintName: G.Models.WebhookIssueCommentEditedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueActiveLockReason
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
    public static class WebhookIssueCommentEditedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentEditedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentEditedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentEditedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssueCommentEditedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentEditedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentEditedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentEditedIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}