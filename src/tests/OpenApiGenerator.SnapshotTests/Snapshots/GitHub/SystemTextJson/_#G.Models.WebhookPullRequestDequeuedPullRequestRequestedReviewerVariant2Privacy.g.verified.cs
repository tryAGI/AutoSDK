//HintName: G.Models.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy
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
    public static class WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}