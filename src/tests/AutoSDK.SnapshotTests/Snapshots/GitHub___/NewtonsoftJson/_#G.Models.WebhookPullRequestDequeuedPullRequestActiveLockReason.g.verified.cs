//HintName: G.Models.WebhookPullRequestDequeuedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedPullRequestActiveLockReason
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
    public static class WebhookPullRequestDequeuedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestDequeuedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestDequeuedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestDequeuedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestDequeuedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestDequeuedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestDequeuedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestDequeuedPullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}