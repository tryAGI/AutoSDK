//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}