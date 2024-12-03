//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.Organization,
                _ => null,
            };
        }
    }
}