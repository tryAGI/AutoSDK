//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}