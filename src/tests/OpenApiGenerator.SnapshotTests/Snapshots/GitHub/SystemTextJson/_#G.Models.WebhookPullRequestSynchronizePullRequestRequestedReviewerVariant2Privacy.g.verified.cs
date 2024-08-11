//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestSynchronizePullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}