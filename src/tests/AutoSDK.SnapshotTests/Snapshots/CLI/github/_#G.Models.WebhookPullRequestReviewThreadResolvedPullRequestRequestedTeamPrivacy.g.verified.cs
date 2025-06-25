//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy.Open => "open",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy.Closed => "closed",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy.Open,
                "closed" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy.Closed,
                "secret" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedTeamPrivacy.Secret,
                _ => null,
            };
        }
    }
}