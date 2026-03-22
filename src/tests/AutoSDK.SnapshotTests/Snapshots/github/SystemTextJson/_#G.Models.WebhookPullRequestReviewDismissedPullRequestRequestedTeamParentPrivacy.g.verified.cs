//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Closed,
                "open" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Open,
                "secret" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}