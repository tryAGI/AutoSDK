//HintName: G.Models.WebhooksPullRequest5ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5ActiveLockReason
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
    public static class WebhooksPullRequest5ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5ActiveLockReason value)
        {
            return value switch
            {
                WebhooksPullRequest5ActiveLockReason.Resolved => "resolved",
                WebhooksPullRequest5ActiveLockReason.OffTopic => "off-topic",
                WebhooksPullRequest5ActiveLockReason.TooHeated => "too heated",
                WebhooksPullRequest5ActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5ActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhooksPullRequest5ActiveLockReason.Resolved,
                "off-topic" => WebhooksPullRequest5ActiveLockReason.OffTopic,
                "too heated" => WebhooksPullRequest5ActiveLockReason.TooHeated,
                "spam" => WebhooksPullRequest5ActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}