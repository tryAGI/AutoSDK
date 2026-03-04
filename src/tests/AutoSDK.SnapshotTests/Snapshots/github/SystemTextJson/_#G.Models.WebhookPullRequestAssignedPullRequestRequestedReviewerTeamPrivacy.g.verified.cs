//HintName: G.Models.WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy
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
    public static class WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy.Open => "open",
                WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy.Closed => "closed",
                WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy.Open,
                "closed" => WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy.Closed,
                "secret" => WebhookPullRequestAssignedPullRequestRequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}