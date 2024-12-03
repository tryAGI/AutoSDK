//HintName: G.Models.WebhookPullRequestSynchronizePullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestActiveLockReason
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
    public static class WebhookPullRequestSynchronizePullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestSynchronizePullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestSynchronizePullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestSynchronizePullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestSynchronizePullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestSynchronizePullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestSynchronizePullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestSynchronizePullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}