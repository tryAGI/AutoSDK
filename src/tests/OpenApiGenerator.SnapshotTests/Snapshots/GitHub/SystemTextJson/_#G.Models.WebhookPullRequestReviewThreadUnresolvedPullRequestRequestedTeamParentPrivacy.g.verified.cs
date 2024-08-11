//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}