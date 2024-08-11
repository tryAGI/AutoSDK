//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}