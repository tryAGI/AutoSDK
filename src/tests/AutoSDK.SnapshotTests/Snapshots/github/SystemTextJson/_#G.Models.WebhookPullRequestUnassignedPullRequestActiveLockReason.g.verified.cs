//HintName: G.Models.WebhookPullRequestUnassignedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestActiveLockReason
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
    public static class WebhookPullRequestUnassignedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestUnassignedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestUnassignedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestUnassignedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestUnassignedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestUnassignedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestUnassignedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestUnassignedPullRequestActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}