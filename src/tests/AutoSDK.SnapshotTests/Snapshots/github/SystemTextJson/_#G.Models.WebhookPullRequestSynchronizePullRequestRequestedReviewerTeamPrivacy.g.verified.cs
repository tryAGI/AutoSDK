//HintName: G.Models.WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy
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
    public static class WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Open => "open",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Open,
                "closed" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Closed,
                "secret" => WebhookPullRequestSynchronizePullRequestRequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}