//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Closed,
                "open" => WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Open,
                "secret" => WebhookPullRequestReviewRequestedVariant2RequestedTeamParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}