//HintName: G.Models.WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy
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
    public static class WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy.Open => "open",
                WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy.Closed => "closed",
                WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy.Open,
                "closed" => WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy.Closed,
                "secret" => WebhookPullRequestLockedPullRequestRequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}