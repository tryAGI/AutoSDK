//HintName: G.Models.WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy
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
    public static class WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy.Open => "open",
                WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy.Closed => "closed",
                WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy.Open,
                "closed" => WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy.Closed,
                "secret" => WebhookPullRequestLabeledPullRequestRequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}