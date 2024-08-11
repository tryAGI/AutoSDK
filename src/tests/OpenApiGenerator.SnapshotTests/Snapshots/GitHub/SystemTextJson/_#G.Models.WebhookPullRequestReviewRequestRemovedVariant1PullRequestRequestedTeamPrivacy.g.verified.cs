//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}