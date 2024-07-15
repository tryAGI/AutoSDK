//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestActiveLockReason
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
    public static class WebhookPullRequestEnqueuedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}