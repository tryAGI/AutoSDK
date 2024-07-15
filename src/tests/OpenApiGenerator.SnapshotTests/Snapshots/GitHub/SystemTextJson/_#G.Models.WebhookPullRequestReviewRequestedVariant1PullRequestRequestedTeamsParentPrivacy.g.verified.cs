//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedTeamsParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}