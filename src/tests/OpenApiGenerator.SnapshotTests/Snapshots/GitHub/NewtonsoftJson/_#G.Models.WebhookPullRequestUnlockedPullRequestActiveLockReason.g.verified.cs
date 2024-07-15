//HintName: G.Models.WebhookPullRequestUnlockedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlockedPullRequestActiveLockReason
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
    public static class WebhookPullRequestUnlockedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestUnlockedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestUnlockedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestUnlockedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestUnlockedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestUnlockedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestUnlockedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestUnlockedPullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}