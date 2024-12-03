//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestMergedByType.Organization,
                _ => null,
            };
        }
    }
}