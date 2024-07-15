//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamsParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}