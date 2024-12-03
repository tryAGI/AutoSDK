//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}