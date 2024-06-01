//HintName: G.Models.WebhookPullRequestLockedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestActiveLockReason
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
    public static class WebhookPullRequestLockedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestLockedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestLockedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestLockedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestLockedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestLockedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestLockedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestLockedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}