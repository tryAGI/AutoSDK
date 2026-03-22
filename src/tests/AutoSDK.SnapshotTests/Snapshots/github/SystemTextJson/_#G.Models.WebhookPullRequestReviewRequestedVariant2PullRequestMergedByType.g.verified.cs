//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType.Bot,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}