//HintName: G.Models.WebhooksPullRequest5RequestedReviewerTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5RequestedReviewerTeamPrivacy
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
    public static class WebhooksPullRequest5RequestedReviewerTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedReviewerTeamPrivacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedReviewerTeamPrivacy.Open => "open",
                WebhooksPullRequest5RequestedReviewerTeamPrivacy.Closed => "closed",
                WebhooksPullRequest5RequestedReviewerTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedReviewerTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksPullRequest5RequestedReviewerTeamPrivacy.Open,
                "closed" => WebhooksPullRequest5RequestedReviewerTeamPrivacy.Closed,
                "secret" => WebhooksPullRequest5RequestedReviewerTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}