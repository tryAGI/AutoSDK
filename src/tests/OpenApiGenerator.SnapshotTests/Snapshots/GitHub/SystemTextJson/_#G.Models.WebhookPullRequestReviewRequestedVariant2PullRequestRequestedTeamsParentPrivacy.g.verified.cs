//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamsParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}