//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy
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
    public static class WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}