//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy
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
    public static class WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy.Open => "open",
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewDismissedPullRequestRequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}