//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewSubmittedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}