//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy
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
    public static class WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy.Open => "open",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy.Closed => "closed",
                WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy.Open,
                "closed" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy.Closed,
                "secret" => WebhookPullRequestUnlabeledPullRequestRequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}