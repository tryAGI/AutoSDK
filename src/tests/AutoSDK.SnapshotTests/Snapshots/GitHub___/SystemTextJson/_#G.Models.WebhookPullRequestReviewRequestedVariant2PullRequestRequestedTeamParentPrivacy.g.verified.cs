//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}