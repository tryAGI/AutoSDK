//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}