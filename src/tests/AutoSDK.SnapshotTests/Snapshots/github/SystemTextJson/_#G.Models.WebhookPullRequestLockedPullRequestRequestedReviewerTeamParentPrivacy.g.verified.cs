//HintName: G.Models.WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy
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
    public static class WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy.Open => "open",
                WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestLockedPullRequestRequestedReviewerTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}